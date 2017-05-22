using Common;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.IO;
using System;

namespace MEF
{
    public class SportHandler // : IPartImportsSatisfiedNotification
    {
        [Import(typeof(ISport))]
        private ISport _sport;

        #region MEF
        //[ImportMany(typeof(ISport))]
        //private List<ISport> _sports;
        #endregion MEF

        public SportHandler()
        {
            MEFSection();
        }

        #region MEF section

        private CompositionContainer _container;
        private void MEFSection()
        {
            var catalog = new AggregateCatalog();
            string currentDirectory = Directory.GetCurrentDirectory();
            catalog.Catalogs.Add(new DirectoryCatalog(currentDirectory));

            _container = new CompositionContainer(catalog);

            this._container.ComposeParts(this);
        }

        #endregion MEF section

        public List<string> GetAllHandledSports()
        {
            return new List<string>()
            {
                $"Name: {_sport.Name}: Equipment: {_sport.Equipment}"
            };

            #region MEF
            //return _sports.Select(s => $"Name: {s.Name}: Equipment: {s.Equipment}").ToList();
            #endregion MEF
        }

        public List<string> CanDoTheSport(string name)
        {
            return new List<string>()
            {
                string.Format("{0}: {1} {2} play that sport", _sport.Name, name, _sport.CanIDoThat(name)? "can" : "can't")
            };

            #region MEF
            //return _sports.Select(s => string.Format("{0}: {1} {2} play that sport", s.Name, name, s.CanIDoThat(name) ? "can" : "can't")).ToList();
            #endregion MEF

        }

        #region MEF - Finished Compose

        //public void OnImportsSatisfied()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("----- Finished compose exports-imports -----------");
        //    foreach (var part in ((AggregateCatalog)_container.Catalog).Parts)
        //    {
        //        Console.WriteLine(part.ToString() + " imported");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}

        #endregion MEF - Finished Compose
    }
}
