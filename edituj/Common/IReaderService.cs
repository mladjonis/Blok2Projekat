﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IReaderService
    {
        [OperationContract]
        Tuple<bool,byte[]> CreateDB(string name);
        [OperationContract]
        Tuple<bool, byte[]> DeleteDB(string name);
        [OperationContract]
        Tuple<bool,byte[]> WriteDB(string name, Element element);
        [OperationContract]
        Tuple<bool, byte[]> EditDB(string name, Element element);
        [OperationContract]
        Tuple<List<Element>,byte[]> ReadDB(string name);
        [OperationContract]
        Tuple<float,byte[]> MedianMonthlyIncomeByCity(string name, string city);
        [OperationContract]
        Tuple<float, byte[]> MedianMonthlyIncome(string name, string country, int year);
        [OperationContract]
        Tuple<Dictionary<string, Element>,byte[]> MaxIncomeByCountry(string name);
    }
}
