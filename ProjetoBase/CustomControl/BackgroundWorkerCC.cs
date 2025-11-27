using ProjetoBase.CustomControl;
using System;
using System.ComponentModel;

namespace ProjetoBase.CustomControls
{
    public class BackgroundWorkerCC : BackgroundWorker
    {
        private InterfaceMenu menuInterface;
        private bool atualizacaoPendente = false;

        public BackgroundWorkerCC()
        {
        }

        public void setMenu(InterfaceMenu menuInterface)
        {
            if (menuInterface == null) throw new ArgumentNullException(nameof(menuInterface));

            if (this.menuInterface != null)
            {
                try
                {
                    DoWork -= this.menuInterface.backgroundWorkerUpdate_DoWork;
                }
                catch { }

                try
                {
                    RunWorkerCompleted -= BackgroundWorkerUpdate_RunWorkerCompleted;
                }
                catch { }
            }

            this.menuInterface = menuInterface;

            DoWork += this.menuInterface.backgroundWorkerUpdate_DoWork;
            RunWorkerCompleted += BackgroundWorkerUpdate_RunWorkerCompleted;
        }

        internal void setMenu(MenuCC menuCC)
        {
            if (menuCC == null) throw new ArgumentNullException(nameof(menuCC));
        }

        public void setAtualizacaoPendente()
        {
            atualizacaoPendente = true;
        }
        private void BackgroundWorkerUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (menuInterface == null) return;

            try
            {
                var menuCC = menuInterface as MenuCC;

                if (atualizacaoPendente)
                {

                    try
                    {
                        var mi = menuInterface.GetType().GetMethod("update");
                        if (mi != null)
                        {
                            mi.Invoke(menuInterface, null);
                        }
                        else if (menuCC != null)
                        {
                            menuCC.update();
                        }
                    }
                    catch
                    {
                    }

                    atualizacaoPendente = false;
                }
            }
            catch
            {

            }
        }
    }
}