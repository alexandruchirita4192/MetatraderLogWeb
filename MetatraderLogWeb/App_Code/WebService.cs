using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Text;

/// <summary>
/// MetatraderLog database stored procedure access
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService
{
    #region Properties
    private static Entities e;
    #endregion Properties

    #region ctor
    public WebService()
    {
        e = new Entities();
    }
    #endregion ctor

    #region Methods

    #region Adding data

    #region Trading Session

    //public string NewTradingSession(string name)
    //{
    //    return "NewTradingSession(" + name + "); Rows affected: " + e.USP_NewTradingSession(name).ToString();
    //}

    [WebMethod]
    public string NewTradingSession(List<Internal.NewTradingSession> list)
    {
        var sb = new StringBuilder();
        if (list != null && list.Count > 0)
            foreach(var item in list)
                sb.AppendLine("NewTradingSession(" + item.name + "); Rows affected: " + e.USP_NewTradingSession(item.name).ToString());
        return sb.ToString();
    }

    [WebMethod]
    public string EndTradingSession(List<Internal.EndTradingSession> list)
    {
        var sb = new StringBuilder();
        if (list != null && list.Count > 0)
            foreach (var item in list)
                sb.AppendLine("EndTradingSession(" + item.name + "); Rows affected: " + e.USP_EndTradingSession(item.name).ToString());
        return sb.ToString();
    }
    #endregion Trading Session

    #region Procedure log
    [WebMethod]
    public string StartProcedureLog(string sessionName, string name, string parameters)
    {
        return "StartProcedureLog(" + sessionName + ", " + name + ", " + parameters + "); Rows affected: " + e.USP_StartProcedureLog(sessionName, name, parameters).ToString();
    }

    [WebMethod]
    public string EndProcedureLog(string sessionName, string name)
    {
        return "EndProcedureLog(" + sessionName + ", " + name + "); Rows affected: " + e.USP_EndProcedureLog(sessionName, name).ToString();
    }
    #endregion Procedure log

    #region Data log, data log detail & debug log
    [WebMethod]
    public string DataLog(List<Internal.DataLog> list)
    {
        var sb = new StringBuilder();
        if (list != null && list.Count > 0)
            foreach (var item in list)
            {
                sb.AppendLine("DataLog(" + item.sessionName + ", " + item.name + ", " + item.data + "); Rows affected: ");
                sb.AppendLine(e.USP_DataLog(item.sessionName, item.name, item.data).ToString());
            }
        return sb.ToString();
    }

    [WebMethod]
    public string DataLogDetail(string sessionName, string name, string detail)
    {
        return "DataLogDetail(" + sessionName + ", " + name + ", " + detail + "); Rows affected: " + e.USP_DataLogDetail(sessionName, name, detail).ToString();
    }

    [WebMethod]
    public string DebugLog(string sessionName, string debugData, DateTime debugTime)
    {
        return "DebugLog(" + sessionName + ", " + debugData + ", " + debugTime.ToString() + "); Rows affected: " + e.USP_DebugLog(sessionName, debugData, debugTime).ToString();
    }
    #endregion Data log, data log detail & debug log

    #endregion Adding data

    #region Delete / clean
    [WebMethod]
    public string DeleteLastSession(string sessionName = null)
    {
        return "DeleteLastSession(" + sessionName + "); Rows affected: " + e.USP_DeleteLastSession(sessionName).ToString();
    }

    [WebMethod]
    public string DeleteAllSessions()
    {
        return "DeleteAllSessions(); Rows affected: " + e.USP_DeleteAllSessions().ToString();
    }

    [WebMethod]
    public string DeleteSymbolData(string sessionName, string symbolName)
    {
        return "DeleteSymbolData(" + sessionName + ", " + symbolName + "); Rows affected: " + e.USP_DeleteSymbolData(sessionName, symbolName).ToString();
    }
    #endregion Delete / clean

    #region Results stuff
    [WebMethod]
    public string GetPartialResults(string sessionName = null)
    {
        var retString = "GetPartialResults(); Rows affected: " + e.USP_GetDataAndDetailsFromSessionName(sessionName).ToString();
        return retString;
    }

    [WebMethod]
    public string GetResultsFromPartialResults()
    {
        var retString = "GetResultsFromPartialResults(); Rows affected: " + e.USP_GetAggregatesFromDetails().ToString();
        return retString;
    }

    [WebMethod]
    public string GetDecisionsIntoResultsTable()
    {
        var retString = "GetDecisionsIntoResultsTable(); Rows affected: " + e.USP_GetMetatraderResultsFromAggregates().ToString();
        return retString;
    }

    /* Does all the stuff that needs to be done */
    [WebMethod]
    public string GetResults(string sessionName = null)
    {
        var retString = "GetResults(" + sessionName + "); Rows affected: " + e.USP_GetResultsFromSessionName(sessionName).ToString();
        return retString;
    }
    #endregion Results stuff

    #region Read methods
    [WebMethod]
    public string ReadResults()
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadResults().ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadResultFromSymbol(string symbolName)
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadResultFromSymbol(symbolName).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadLastDataLog(string sessionName = null)
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadLastDataLog(sessionName).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadLastDataLogDetail(string sessionName = null)
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadLastDataLogDetail(sessionName).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadLastProcedureLog(string sessionName = null)
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadLastProcedureLog(sessionName).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadLastDataLogAndDetail(string sessionName = null)
    {
        List<string> list = new List<string>();
        var array = e.USP_ReadLastDataLogAndDetail(sessionName).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadResult(string orderNo)
    {
        List<string> list = new List<string>();
        var orderNumber = orderNo.ToNullableInt();
        var array = e.USP_ReadResult(orderNumber).ToArray();
        foreach (var listitem in array)
            list.Add(listitem.ToXML());

        return string.Join("\n", list);
    }

    [WebMethod]
    public string ReadLastSymbol(string sessionName = null)
    {
        return e.USP_GetLastSymbolOfSimulation(sessionName).ToList().First();
    }

    [WebMethod]
    public string ReadConfigTable()
    {
        return e.USP_GetConfigTableData().ToArray().ToXML().ToString();
    }

    #endregion Read methods

    #region Test methods
    [WebMethod]
    public string TestSimpleMethod()
    {
        return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
    }

    [WebMethod]
    public string TestMethod(List<String> list)
    {
        return string.Join("\n", list);
    }

    public struct TestStruct
    {
        public String sessionName, debugData;
        public DateTime debugTime;
    }
    [WebMethod]
    public string TestMethod2(List<TestStruct> list)
    {
        return string.Join("\n", list);
    }

    [WebMethod]
    public string TestMethod3(List<TestStruct> list)
    {
        string result = String.Empty;
        foreach (var listitem in list)
            result += e.USP_DebugLog(listitem.sessionName, listitem.debugData, listitem.debugTime).ToString();
        return result;
    }

    #endregion Test methods

    #region Bulk methods

    // BulkDataLog
    public struct BulkDataLogStruct
    {
        public String sessionName, name, data;
    }
    [WebMethod]
    public void BulkDataLog(List<BulkDataLogStruct> list)
    {
        foreach (var item in list)
            e.USP_DataLog(item.sessionName, item.name, item.data);
    }


    // BulkDataLogDetail
    public struct BulkDataLogDetailStruct
    {
        public String sessionName, name, detail;
    }
    [WebMethod]
    public void BulkDataLogDetail(List<BulkDataLogDetailStruct> list)
    {
        foreach (var item in list)
            e.USP_DataLogDetail(item.sessionName, item.name, item.detail);
    }


    // BulkDebugLog
    public struct BulkDebugLogStruct
    {
        public String sessionName, debugData;
        public DateTime debugTime;
    }
    [WebMethod]
    public void BulkDebugLog(List<BulkDebugLogStruct> list)
    {
        foreach (var item in list)
            e.USP_DebugLog(item.sessionName, item.debugData, item.debugTime);
    }

    #endregion Bulk methods

    #endregion Methods
}

namespace Internal
{
    public struct NewTradingSession
    {
        public string name;
    }
    public struct EndTradingSession
    {
        public string name;
    }
    public struct DataLog
    {
        public string sessionName;
        public string name;
        public string data;
    }
}
