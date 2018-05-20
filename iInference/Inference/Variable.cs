using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public class Variable
    {
        string _name;
        List<String> _relations;
        bool _logicaltrue;
        
        public Variable()
        {
            _logicaltrue = false;
        }

        public List<string> Relations
        {
            get
            {
                return _relations;
            }

            set
            {
                _relations = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public bool Logicaltrue
        {
            get
            {
                return _logicaltrue;
            }

            set
            {
                _logicaltrue = value;
            }
        }

    }

}
