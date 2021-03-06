﻿using System;
using System.Collections.Generic;

namespace TestJson
{
   

    public class MyHaandvaekere
    {
        public List<Haandvaerker> Haandvaerkere { get; set; }
    }

    public class Haandvaerker
    {
        public string id { get; set; }
        public DateTime hvAnsaettelsedato { get; set; }
        public string hvEfternavn { get; set; }
        public string hvFagomraade { get; set; }
        public string hvFornavn { get; set; }
        public int haandvaerkerId { get; set; }
        public Vaerktoejskasse[] vaerktoejskasse { get; set; }
    }

    public class Vaerktoejskasse
    {
        public string id { get; set; }
        public int vtkId { get; set; }
        public DateTime vtkAnskaffet { get; set; }
        public string vtkFabrikat { get; set; }
        public int vtkEjesAf { get; set; }
        public string vtkModel { get; set; }
        public string vtkSerienummer { get; set; }
        public string vtkFarve { get; set; }
        public Haandvaerker ejesAfNavigation { get; set; }
        public Vaerktoej[] vaerktoej { get; set; }
    }

    public class Ejesafnavigation
    {
        public string _ref { get; set; }
    }

    public class Vaerktoej
    {
        public string id { get; set; }
        public int vtId { get; set; }
        public DateTime vtAnskaffet { get; set; }
        public string vtFabrikat { get; set; }
        public string vtModel { get; set; }
        public string vtSerienr { get; set; }
        public string vtType { get; set; }
        public int liggerIvtk { get; set; }
        public Vaerktoejskasse liggerIvtkNavigation { get; set; }
    }

    public class Liggerivtknavigation
    {
        public string _ref { get; set; }
    }

}
