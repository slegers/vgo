using MovieDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF = System.Windows.Forms;

namespace MovieDatabaseWinForms.Services {
    public class MessageBoxService : IMessageBoxService {
        public MessageBoxResult Show(object owner = null, string text = "", string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.OK) {
            var o = owner as WF.IWin32Window;
            return (MessageBoxResult)WF.MessageBox.Show(o, text, caption, (WF.MessageBoxButtons)buttons, (WF.MessageBoxIcon)icon);
        }
    }
}
