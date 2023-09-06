using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PCSCT.BindintEntiy
{
    public class ToolbarMenuSetting
    {
        private Boolean viewFileSystemMenuFlag = true;
        private Boolean viewMonitorMenuFlag = true;

        public Boolean ViewFileSystemMenuFlag 
        {
            get { return viewFileSystemMenuFlag; }
            set
            {
                viewFileSystemMenuFlag = value;
            }

        }
        
        public Boolean ViewMonitorMenuFlag
        {
            get { return viewMonitorMenuFlag; }
            set
            {
                viewMonitorMenuFlag = value;
            }

        }
    }
}
