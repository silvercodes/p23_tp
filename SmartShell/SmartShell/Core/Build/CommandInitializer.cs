using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShell.Core.Build
{
    internal class CommandInitializer
    {
        private IBuilder<string> titleBuilder;
        private IBuilder<CommandArgument> argumentBuilder;
        private IBuilder<List<CommandOption>?> optionsBuilder;
        public CommandInitializer
        (
            IBuilder<string> titleBuilder,
            IBuilder<CommandArgument> argumentBuilder,
            IBuilder<List<CommandOption>?> optionsBuilder
        )
        { 
            this.titleBuilder = titleBuilder;
            this.argumentBuilder = argumentBuilder;
            this.optionsBuilder = optionsBuilder;
        }

        public void Build(Command cmd)
        {
            cmd.Title = titleBuilder.Build(cmd.Signature);

            cmd.Argument = argumentBuilder.Build(cmd.Signature);

            cmd.Options = optionsBuilder.Build(cmd.Signature);
        }
    }
}
