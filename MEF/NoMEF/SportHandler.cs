using Common;
using Dukim;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoMEF
{
    public class SportHandler
    {
        private ISport _sport = new Dukim.Dukim();

        #region Reflection
        //public SportHandler()
        //{
        //    var files = Directory.GetFiles(Directory.GetCurrentDirectory());
        //    foreach (var file in files)
        //    {
        //        if (file.ToUpper().Contains("DLL"))
        //        {
        //            var dukimAssembly = AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(file));
        //            var types = dukimAssembly.DefinedTypes;
        //
        //            var sportType = types.FirstOrDefault(t => t.GetInterfaces().Contains(typeof(ISport)));
        //
        //            if(sportType != null)
        //            {
        //                _sport = (ISport)sportType.Assembly.CreateInstance(sportType.FullName);
        //                break;
        //            }
        //        }
        //    }
        //}

        #endregion Reflection


        public List<string> GetAllHandledSports()
        {
            return new List<string>()
            {
                $"Name: {_sport.Name}: Equipment: {_sport.Equipment}"
            };
        }

        public List<string> CanDoTheSport(string name)
        {
            return new List<string>()
            {
                string.Format("{0}: {1} {2} play that sport", _sport.Name, name, _sport.CanIDoThat(name)? "can" : "can't")
            };
        }        
    }
}
