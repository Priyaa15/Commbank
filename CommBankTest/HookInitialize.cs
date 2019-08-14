
using Commbank.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommBankTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Firefox)
        {
            InitializeSettings();
            NavigateSite();
        }
    }
}
