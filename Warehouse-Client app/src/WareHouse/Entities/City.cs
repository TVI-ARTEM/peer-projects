using System;
using System.Collections.Generic;
using System.Linq;
using WareHouse.AppResources;
using WareHouse.Exceptions;

namespace WareHouse.Entities
{
    public sealed class City
    {
        /// <summary>
        /// City's id and city's distance to Moscow.
        /// </summary>
        public (int, double) Values { get;}
        /// <summary>
        /// City's name.
        /// </summary>
        public string Name { get; }

        public static explicit operator int(City city) => city.Values.Item1;

        private City((int, double) values, string name)
        {
            Values = values;
            Name = name;
        }

        public City()
        {
        }

        public static City Moscow = new City((0, 0), ApplicationStrings.CityMoscow);
        public static City SaintPeter = new City((1, 706), ApplicationStrings.CitySaintPeter);
        public static City Novosibirsk = new City((2, 3382), ApplicationStrings.CityNovosibirsk);
        public static City Yekaterinburg = new City((3, 1787), ApplicationStrings.CityYekaterinburg);
        public static City Kazan = new City((4, 0), ApplicationStrings.CityKazan);
        public static City NizhnyNovgorod = new City((5, 822), ApplicationStrings.CityNizhnyNovgorod);
        public static City Chelyabinsk = new City((6, 1783), ApplicationStrings.CityChelyabinsk);
        public static City Omsk = new City((7, 2732), ApplicationStrings.CityOmsk);
        public static City Samara = new City((8, 1065), ApplicationStrings.CitySamara);
        public static City RostovOnDon = new City((9, 1082), ApplicationStrings.CityRostovOnDon);
        public static City Ufa = new City((10, 1352), ApplicationStrings.CityUfa);
        public static City Krasnoyarsk = new City((11, 4159), ApplicationStrings.CityKrasnoyarsk);
        public static City Permian = new City((12, 1430), ApplicationStrings.CityPermian);
        public static City Voronezh = new City((13, 520), ApplicationStrings.CityVoronezh);
        public static City Volgograd = new City((14, 975), ApplicationStrings.CityVolgograd);

        /// <summary>
        /// Get cities names.
        /// </summary>
        /// <returns>Cities name.</returns>
        public static List<string> GetNames()
        {
            return new List<string>
            {
                Moscow.Name,
                SaintPeter.Name,
                Novosibirsk.Name,
                Yekaterinburg.Name,
                Kazan.Name,
                NizhnyNovgorod.Name,
                Chelyabinsk.Name,
                Omsk.Name,
                Samara.Name,
                RostovOnDon.Name,
                Ufa.Name,
                Krasnoyarsk.Name,
                Permian.Name,
                Voronezh.Name,
                Volgograd.Name
            };
        }

        /// <summary>
        /// Get city by id.
        /// </summary>
        /// <param name="id">City id.</param>
        /// <returns>City</returns>
        public static City GetById(int id)
        {
            try
            {
                return new List<City>
                {
                    Moscow,
                    SaintPeter,
                    Novosibirsk,
                    Yekaterinburg,
                    Kazan,
                    NizhnyNovgorod,
                    Chelyabinsk,
                    Omsk,
                    Samara,
                    RostovOnDon,
                    Ufa,
                    Krasnoyarsk,
                    Permian,
                    Voronezh,
                    Volgograd
                }.First(city => city.Values.Item1 == id);
            }
            catch
            {
                throw new CustomDataException(ApplicationStrings.CityIdException);
            }
        }


        public override string ToString() => Name;
    }
}