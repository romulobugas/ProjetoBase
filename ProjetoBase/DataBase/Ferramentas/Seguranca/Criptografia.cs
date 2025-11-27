using System;
using System.Security.Cryptography;

namespace ProjetoBase.Ferramentas.Seguranca
{
    public static class Criptografia
    {
        // Gera hash da senha com salt (PBKDF2)
        public static string GerarHashSenha(string senha)
        {
            if (senha == null) throw new ArgumentNullException(nameof(senha));

            using (var deriveBytes = new Rfc2898DeriveBytes(senha, 16, 10000))
            {
                byte[] salt = deriveBytes.Salt;              // 16 bytes
                byte[] key = deriveBytes.GetBytes(32);       // 32 bytes

                byte[] hashBytes = new byte[16 + 32];
                Buffer.BlockCopy(salt, 0, hashBytes, 0, 16);
                Buffer.BlockCopy(key, 0, hashBytes, 16, 32);

                return Convert.ToBase64String(hashBytes);
            }
        }

        // Verifica a senha comparando o hash armazenado (tempo-constante)
        public static bool VerificarSenha(string senhaDigitada, string senhaHashBanco)
        {
            if (senhaDigitada == null) throw new ArgumentNullException(nameof(senhaDigitada));
            if (string.IsNullOrWhiteSpace(senhaHashBanco)) return false;

            byte[] hashBytes;
            try
            {
                hashBytes = Convert.FromBase64String(senhaHashBanco);
            }
            catch
            {
                return false;
            }

            if (hashBytes.Length != 48) // 16 salt + 32 key
                return false;

            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashBytes, 0, salt, 0, 16);

            byte[] keyOriginal = new byte[32];
            Buffer.BlockCopy(hashBytes, 16, keyOriginal, 0, 32);

            using (var deriveBytes = new Rfc2898DeriveBytes(senhaDigitada, salt, 10000))
            {
                byte[] keyTest = deriveBytes.GetBytes(32);
                return FixedTimeEquals(keyOriginal, keyTest);
            }
        }

        // Comparador em tempo-constante (compatível com qualquer .NET)
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
    }
}
