using System.Collections.Generic;
using Tests.poco;

namespace Tests
{
    static class Stubs
    {
        public static PlanViewModel HardCodedModel()
        {
            return new PlanViewModel
            {
                CompletedModel = true,
                From =
                    new Location
                    {
                        Address = "Barbu Vacarescu, Bucharest, Romania",
                        Lat = (decimal)44.464244,
                        Lng = (decimal)26.107983999999988,
                        Details =
                            new LocationDetails
                            {
                                Summary = "summary for Barbu Vacarescu"
                            }
                    },
                Destinations =
                    new List<Location>
                    {
                        new Location 
                        { 
                            Address= "Ștefan cel Mare, Șoseaua Ștefan cel Mare, Bucharest, Romania",
                            Lat = (decimal)44.452729,
                            Lng = (decimal)26.105661000000055,
                            Details = 
                                new LocationDetails
                                {
                                    Summary = "summary for Ștefan cel Mare"
                                }
                        },
                        new Location 
                        { 
                            Address= "Bulevardul Pache Protopopescu, Bucharest, Romania",
                            Lat = (decimal)44.4398205,
                            Lng = (decimal)26.125605800000017,
                            Details = 
                                new LocationDetails
                                {
                                    Summary = "summary for Pache Protopopescu"
                                }
                        },
                        new Location 
                        { 
                            Address= "Bulevardul Dacia, Bucharest, Romania",
                            Lat = (decimal)44.446488,
                            Lng = (decimal)26.10384829999998,
                            Details = 
                                new LocationDetails
                                {
                                    Summary = "summary for Dacia"
                                }
                        }

                    }
            };
        }
    }
}
