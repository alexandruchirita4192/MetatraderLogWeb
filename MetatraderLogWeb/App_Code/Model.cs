﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class ConfigTable
{
    public int ConfigTableId { get; set; }
    public string Config { get; set; }
    public string Value { get; set; }
}

public partial class DataAndAggregate
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountServer { get; set; }
    public Nullable<long> AccountNumber { get; set; }
    public string AccountClientName { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string LotName { get; set; }
    public Nullable<decimal> Spread { get; set; }
    public Nullable<decimal> SpreadPips { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<System.DateTime> LastOrderTime { get; set; }
    public Nullable<System.DateTime> PeriodStartTime { get; set; }
    public Nullable<System.DateTime> PeriodEndTime { get; set; }
    public Nullable<int> OrdersCount { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> SumLots { get; set; }
    public Nullable<decimal> SumProfit { get; set; }
    public Nullable<decimal> SumInverseProfit { get; set; }
    public Nullable<decimal> AvgTakeProfit { get; set; }
    public Nullable<decimal> AvgStopLoss { get; set; }
    public Nullable<decimal> TakeProfitPips { get; set; }
    public Nullable<decimal> StopLossPips { get; set; }
    public Nullable<int> SumOrderIsClosed { get; set; }
    public Nullable<int> SumOrderClosedByStopLoss { get; set; }
    public Nullable<int> SumOrderClosedByTakeProfit { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> SessionId { get; set; }
    public Nullable<decimal> ProcentualProfit { get; set; }
    public Nullable<decimal> InverseProcentualProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<int> SumNotClosedOrders { get; set; }
}

public partial class DataAndDetail
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData_AccountCompany { get; set; }
    public string DataLogData_AccountServer { get; set; }
    public Nullable<long> DataLogData_AccountNumber { get; set; }
    public string DataLogData_AccountClientName { get; set; }
    public string DataLogData_AccountCurrency { get; set; }
    public string DataLogData_Symbol { get; set; }
    public string DataLogData_Period { get; set; }
    public string DataLogData_DecisionName { get; set; }
    public string DataLogData_TransactionName { get; set; }
    public string DataLogData_LotName { get; set; }
    public Nullable<decimal> DataLogData_Spread { get; set; }
    public Nullable<decimal> DataLogData_SpreadPips { get; set; }
    public Nullable<int> DataLogData_Bars { get; set; }
    public Nullable<int> DataLogData_Volume { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodStartTime { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodEndTime { get; set; }
    public Nullable<int> DataLogData_OrdersCount { get; set; }
    public Nullable<decimal> DataLogData_MinLots { get; set; }
    public Nullable<decimal> DataLogData_MinLotsMargin { get; set; }
    public Nullable<int> DataLogData_LastDecisionBar { get; set; }
    public Nullable<System.DateTime> DataLogData_LastDecisionTime { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public Nullable<decimal> DataLogDetail_Lots { get; set; }
    public Nullable<decimal> DataLogDetail_OpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_InverseOpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_DecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_BuyDecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_SellDecisionType { get; set; }
    public Nullable<bool> DataLogDetail_UninitializedProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_Profit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialInverseTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialInverseStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfitPips { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLossPips { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderIsClosed { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderIsClosed { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_ClosePrice { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseClosePrice { get; set; }
    public Nullable<System.DateTime> DataLogDetail_TranData_OrderCloseTime { get; set; }
    public Nullable<System.DateTime> DataLogDetail_TranData_InverseOrderCloseTime { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByStopLoss { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByTakeProfit { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderClosedByStopLoss { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderClosedByTakeProfit { get; set; }
    public Nullable<bool> DataLogDetail_IrregularLimits { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_IrregularLimitsType { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class DatabaseVersion
{
    public int DatabaseVersionId { get; set; }
    public Nullable<System.DateTime> UpdateDate { get; set; }
    public Nullable<int> VersionNumber { get; set; }
}

public partial class DataLog
{
    public DataLog()
    {
        this.DataLogDetails = new HashSet<DataLogDetail>();
    }

    public int DataLogId { get; set; }
    public string Name { get; set; }
    public string Data { get; set; }
    public Nullable<System.DateTime> LogTime { get; set; }
    public Nullable<int> SessionId { get; set; }

    public virtual TradingSession TradingSession { get; set; }
    public virtual ICollection<DataLogDetail> DataLogDetails { get; set; }
}

public partial class DataLogDetail
{
    public int DataLogDetailId { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
    public Nullable<System.DateTime> LogTime { get; set; }
    public Nullable<int> DataLogId { get; set; }

    public virtual DataLog DataLog { get; set; }
}

public partial class DebugLog
{
    public int DebugLogId { get; set; }
    public System.DateTime DebugTime { get; set; }
    public string DebugData { get; set; }
    public Nullable<int> SessionId { get; set; }

    public virtual TradingSession TradingSession { get; set; }
}

public partial class InitialAggregateDetail
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountServer { get; set; }
    public Nullable<long> AccountNumber { get; set; }
    public string AccountClientName { get; set; }
    public string AccountCurrency { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string LotName { get; set; }
    public Nullable<int> Volume { get; set; }
    public Nullable<decimal> Spread { get; set; }
    public Nullable<decimal> SpreadPips { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<System.DateTime> LastOrderTime { get; set; }
    public Nullable<System.DateTime> PeriodStartTime { get; set; }
    public Nullable<System.DateTime> PeriodEndTime { get; set; }
    public Nullable<int> OrdersCount { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> SumLots { get; set; }
    public Nullable<decimal> SumProfit { get; set; }
    public Nullable<decimal> SumInverseProfit { get; set; }
    public Nullable<decimal> AvgTakeProfit { get; set; }
    public Nullable<decimal> AvgStopLoss { get; set; }
    public Nullable<decimal> AvgStopLossPips { get; set; }
    public Nullable<decimal> AvgTakeProfitPips { get; set; }
    public Nullable<decimal> TakeProfitPips { get; set; }
    public Nullable<decimal> StopLossPips { get; set; }
    public Nullable<int> SumOrderIsClosed { get; set; }
    public Nullable<int> SumOrderClosedByStopLoss { get; set; }
    public Nullable<int> SumOrderClosedByTakeProfit { get; set; }
    public Nullable<int> SumOrderProfitable { get; set; }
    public Nullable<int> SumInverseOrderProfitable { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> SessionId { get; set; }
    public Nullable<int> ProcentualProfit { get; set; }
    public Nullable<int> InverseProcentualProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<int> SumNotClosedOrders { get; set; }
}

public partial class ProcedureLog
{
    public int ProcedureLogId { get; set; }
    public string Name { get; set; }
    public string ParamsToString { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public Nullable<int> SessionId { get; set; }

    public virtual TradingSession TradingSession { get; set; }
}

public partial class TradingSession
{
    public TradingSession()
    {
        this.DataLogs = new HashSet<DataLog>();
        this.DebugLogs = new HashSet<DebugLog>();
        this.ProcedureLogs = new HashSet<ProcedureLog>();
    }

    public int SessionId { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public string Name { get; set; }

    public virtual ICollection<DataLog> DataLogs { get; set; }
    public virtual ICollection<DebugLog> DebugLogs { get; set; }
    public virtual ICollection<ProcedureLog> ProcedureLogs { get; set; }
}

public partial class vwDataToXml
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public string DataLogDetail { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class vwInitialAggregateDetail
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountServer { get; set; }
    public Nullable<long> AccountNumber { get; set; }
    public string AccountClientName { get; set; }
    public string AccountCurrency { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string LotName { get; set; }
    public Nullable<int> Volume { get; set; }
    public Nullable<decimal> Spread { get; set; }
    public Nullable<decimal> SpreadPips { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<System.DateTime> LastOrderTime { get; set; }
    public Nullable<System.DateTime> PeriodStartTime { get; set; }
    public Nullable<System.DateTime> PeriodEndTime { get; set; }
    public Nullable<int> OrdersCount { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> SumLots { get; set; }
    public Nullable<decimal> SumProfit { get; set; }
    public Nullable<decimal> SumInverseProfit { get; set; }
    public Nullable<decimal> AvgTakeProfit { get; set; }
    public Nullable<decimal> AvgStopLoss { get; set; }
    public Nullable<decimal> AvgStopLossPips { get; set; }
    public Nullable<decimal> AvgTakeProfitPips { get; set; }
    public Nullable<decimal> TakeProfitPips { get; set; }
    public Nullable<decimal> StopLossPips { get; set; }
    public Nullable<int> SumOrderIsClosed { get; set; }
    public Nullable<int> SumOrderClosedByStopLoss { get; set; }
    public Nullable<int> SumOrderClosedByTakeProfit { get; set; }
    public Nullable<int> SumOrderProfitable { get; set; }
    public Nullable<int> SumInverseOrderProfitable { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> SessionId { get; set; }
    public Nullable<int> ProcentualProfit { get; set; }
    public Nullable<int> InverseProcentualProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<int> SumNotClosedOrders { get; set; }
}

public partial class vwLastMetatraderPartialResultsPost
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData_AccountCompany { get; set; }
    public string DataLogData_AccountServer { get; set; }
    public Nullable<long> DataLogData_AccountNumber { get; set; }
    public string DataLogData_AccountClientName { get; set; }
    public string DataLogData_Symbol { get; set; }
    public string DataLogData_Period { get; set; }
    public string DataLogData_DecisionName { get; set; }
    public string DataLogData_TransactionName { get; set; }
    public string DataLogData_LotName { get; set; }
    public Nullable<decimal> DataLogData_Spread { get; set; }
    public Nullable<decimal> DataLogData_SpreadPips { get; set; }
    public Nullable<int> DataLogData_Bars { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodStartTime { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodEndTime { get; set; }
    public Nullable<int> DataLogData_OrdersCount { get; set; }
    public Nullable<decimal> DataLogData_MinLots { get; set; }
    public Nullable<decimal> DataLogData_MinLotsMargin { get; set; }
    public Nullable<int> DataLogData_LastDecisionBar { get; set; }
    public Nullable<System.DateTime> DataLogData_LastDecisionTime { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public Nullable<decimal> DataLogDetail_Lots { get; set; }
    public Nullable<decimal> DataLogDetail_OpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_InverseOpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_DecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_BuyDecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_SellDecisionType { get; set; }
    public Nullable<bool> DataLogDetail_UninitializedProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_Profit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfitPips { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLossPips { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderIsClosed { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_ClosePrice { get; set; }
    public Nullable<System.DateTime> DataLogDetail_TranData_OrderCloseTime { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByStopLoss { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByTakeProfit { get; set; }
    public Nullable<bool> DataLogDetail_IrregularLimits { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_IrregularLimitsType { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class vwLastMetatraderPartialResultsPre
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public string DataLogDetail { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class vwLastMetatraderResultsPre
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData_AccountCompany { get; set; }
    public string DataLogData_AccountServer { get; set; }
    public Nullable<long> DataLogData_AccountNumber { get; set; }
    public string DataLogData_AccountClientName { get; set; }
    public string DataLogData_Symbol { get; set; }
    public string DataLogData_Period { get; set; }
    public string DataLogData_DecisionName { get; set; }
    public string DataLogData_TransactionName { get; set; }
    public string DataLogData_LotName { get; set; }
    public Nullable<decimal> DataLogData_Spread { get; set; }
    public Nullable<decimal> DataLogData_SpreadPips { get; set; }
    public Nullable<int> DataLogData_Bars { get; set; }
    public Nullable<int> DataLogData_LastDecisionBar { get; set; }
    public Nullable<System.DateTime> DataLogData_LastDecisionTime { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodStartTime { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodEndTime { get; set; }
    public Nullable<int> DataLogData_OrdersCount { get; set; }
    public Nullable<decimal> DataLogData_MinLots { get; set; }
    public Nullable<decimal> DataLogData_MinLotsMargin { get; set; }
    public Nullable<decimal> SumProfit { get; set; }
    public Nullable<decimal> SumInverseProfit { get; set; }
    public Nullable<decimal> TakeProfit { get; set; }
    public Nullable<decimal> StopLoss { get; set; }
    public Nullable<decimal> TakeProfitPips { get; set; }
    public Nullable<decimal> StopLossPips { get; set; }
    public Nullable<int> SumOrderIsClosed { get; set; }
    public Nullable<int> SumOrderClosedByStopLoss { get; set; }
    public Nullable<int> SumOrderClosedByTakeProfit { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<System.DateTime> LastOrderTime { get; set; }
    public Nullable<int> SessionId { get; set; }
    public Nullable<decimal> ProcentualProfit { get; set; }
    public Nullable<decimal> InverseProcentualProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<int> SumNotClosedOrders { get; set; }
}

public partial class vwTradingSession
{
    public int SessionId { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public string Name { get; set; }
    public Nullable<int> RunMinutes { get; set; }
}

public partial class vwXmlExtractIntoTable
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData_AccountCompany { get; set; }
    public string DataLogData_AccountServer { get; set; }
    public Nullable<long> DataLogData_AccountNumber { get; set; }
    public string DataLogData_AccountClientName { get; set; }
    public string DataLogData_AccountCurrency { get; set; }
    public string DataLogData_Symbol { get; set; }
    public string DataLogData_Period { get; set; }
    public string DataLogData_DecisionName { get; set; }
    public string DataLogData_TransactionName { get; set; }
    public string DataLogData_LotName { get; set; }
    public Nullable<decimal> DataLogData_Spread { get; set; }
    public Nullable<decimal> DataLogData_SpreadPips { get; set; }
    public Nullable<int> DataLogData_Bars { get; set; }
    public Nullable<int> DataLogData_Volume { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodStartTime { get; set; }
    public Nullable<System.DateTime> DataLogData_PeriodEndTime { get; set; }
    public Nullable<int> DataLogData_OrdersCount { get; set; }
    public Nullable<decimal> DataLogData_MinLots { get; set; }
    public Nullable<decimal> DataLogData_MinLotsMargin { get; set; }
    public Nullable<int> DataLogData_LastDecisionBar { get; set; }
    public Nullable<System.DateTime> DataLogData_LastDecisionTime { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public Nullable<decimal> DataLogDetail_Lots { get; set; }
    public Nullable<decimal> DataLogDetail_OpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_InverseOpenPrice { get; set; }
    public Nullable<decimal> DataLogDetail_DecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_BuyDecisionType { get; set; }
    public Nullable<decimal> DataLogDetail_SellDecisionType { get; set; }
    public Nullable<bool> DataLogDetail_UninitializedProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_Profit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialInverseTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InitialInverseStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseTakeProfit { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseStopLoss { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_TakeProfitPips { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_StopLossPips { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderIsClosed { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderIsClosed { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_ClosePrice { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_InverseClosePrice { get; set; }
    public Nullable<System.DateTime> DataLogDetail_TranData_OrderCloseTime { get; set; }
    public Nullable<System.DateTime> DataLogDetail_TranData_InverseOrderCloseTime { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByStopLoss { get; set; }
    public Nullable<bool> DataLogDetail_TranData_OrderClosedByTakeProfit { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderClosedByStopLoss { get; set; }
    public Nullable<bool> DataLogDetail_TranData_InverseOrderClosedByTakeProfit { get; set; }
    public Nullable<bool> DataLogDetail_IrregularLimits { get; set; }
    public Nullable<decimal> DataLogDetail_TranData_IrregularLimitsType { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class XmlDataAndDetail
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public string DataLogDetail { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class USP_GetConfigTableData_Result
{
    public int ConfigTableId { get; set; }
    public string Config { get; set; }
    public string Value { get; set; }
}

public partial class USP_GetValidTradingSessionsAndQueries_Result
{
    public int SessionId { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public string Name { get; set; }
    public Nullable<int> Count { get; set; }
}

public partial class USP_ReadLastDataLog_Result
{
    public int DataLogId { get; set; }
    public string Name { get; set; }
    public string Data { get; set; }
    public Nullable<System.DateTime> LogTime { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class USP_ReadLastDataLogAndDetail_Result
{
    public int DataLogId { get; set; }
    public string DataLogName { get; set; }
    public string DataLogData { get; set; }
    public Nullable<System.DateTime> DataLogTime { get; set; }
    public Nullable<int> DataLogDetailId { get; set; }
    public string DataLogDetail { get; set; }
    public Nullable<System.DateTime> DataLogDetailTime { get; set; }
    public string DataLogDetailName { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class USP_ReadLastDataLogDetail_Result
{
    public int DataLogDetailId { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
    public Nullable<System.DateTime> LogTime { get; set; }
    public Nullable<int> DataLogId { get; set; }
}

public partial class USP_ReadLastProcedureLog_Result
{
    public int ProcedureLogId { get; set; }
    public string Name { get; set; }
    public string ParamsToString { get; set; }
    public Nullable<System.DateTime> StartTime { get; set; }
    public Nullable<System.DateTime> EndTime { get; set; }
    public Nullable<int> SessionId { get; set; }
}

public partial class USP_ReadResult_Result
{
    public Nullable<long> OrderNo { get; set; }
    public Nullable<int> MaxOrderNo { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountCurrency { get; set; }
    public string LotName { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> AvgLotsMargin { get; set; }
    public Nullable<decimal> SumLotsMargin { get; set; }
    public Nullable<decimal> BestSumProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> BarsPerOrders { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<int> SumClosedOrders { get; set; }
    public Nullable<int> PositiveOrdersCount { get; set; }
    public Nullable<int> InversePositiveOrdersCount { get; set; }
    public Nullable<decimal> ProcentualProfitResult { get; set; }
    public Nullable<long> OrdersCountDecision { get; set; }
    public Nullable<long> LastDecisionBarDecision { get; set; }
    public Nullable<long> MinLotsMarginDecision { get; set; }
    public Nullable<long> SpreadDecision { get; set; }
    public Nullable<long> FullProcentualProfitDecision { get; set; }
    public Nullable<long> PositiveOrdersCountDecision { get; set; }
    public Nullable<long> BestSumProfitDecision { get; set; }
    public Nullable<long> VolumeDecision { get; set; }
    public Nullable<long> BarsPerOrdersDecision { get; set; }
}

public partial class USP_ReadResultFromSymbol_Result
{
    public Nullable<long> OrderNo { get; set; }
    public Nullable<int> MaxOrderNo { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountCurrency { get; set; }
    public string LotName { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> AvgLotsMargin { get; set; }
    public Nullable<decimal> SumLotsMargin { get; set; }
    public Nullable<decimal> BestSumProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> BarsPerOrders { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<int> SumClosedOrders { get; set; }
    public Nullable<int> PositiveOrdersCount { get; set; }
    public Nullable<int> InversePositiveOrdersCount { get; set; }
    public Nullable<decimal> ProcentualProfitResult { get; set; }
    public Nullable<long> OrdersCountDecision { get; set; }
    public Nullable<long> LastDecisionBarDecision { get; set; }
    public Nullable<long> MinLotsMarginDecision { get; set; }
    public Nullable<long> SpreadDecision { get; set; }
    public Nullable<long> FullProcentualProfitDecision { get; set; }
    public Nullable<long> PositiveOrdersCountDecision { get; set; }
    public Nullable<long> BestSumProfitDecision { get; set; }
    public Nullable<long> VolumeDecision { get; set; }
    public Nullable<long> BarsPerOrdersDecision { get; set; }
}

public partial class USP_ReadResults_Result
{
    public Nullable<long> OrderNo { get; set; }
    public Nullable<int> MaxOrderNo { get; set; }
    public string Symbol { get; set; }
    public string Period { get; set; }
    public string DecisionName { get; set; }
    public string TransactionName { get; set; }
    public string AccountCompany { get; set; }
    public string AccountCurrency { get; set; }
    public string LotName { get; set; }
    public Nullable<decimal> MinLots { get; set; }
    public Nullable<decimal> MinLotsMargin { get; set; }
    public Nullable<decimal> AvgLots { get; set; }
    public Nullable<decimal> AvgLotsMargin { get; set; }
    public Nullable<decimal> SumLotsMargin { get; set; }
    public Nullable<decimal> BestSumProfit { get; set; }
    public Nullable<bool> IsInverseDecision { get; set; }
    public Nullable<bool> IrregularLimits { get; set; }
    public Nullable<decimal> IrregularLimitsType { get; set; }
    public Nullable<int> Bars { get; set; }
    public Nullable<int> BarsPerOrders { get; set; }
    public Nullable<int> LastDecisionBar { get; set; }
    public Nullable<System.DateTime> LastDecisionTime { get; set; }
    public Nullable<int> SumClosedOrders { get; set; }
    public Nullable<int> PositiveOrdersCount { get; set; }
    public Nullable<int> InversePositiveOrdersCount { get; set; }
    public Nullable<decimal> ProcentualProfitResult { get; set; }
    public Nullable<long> OrdersCountDecision { get; set; }
    public Nullable<long> LastDecisionBarDecision { get; set; }
    public Nullable<long> MinLotsMarginDecision { get; set; }
    public Nullable<long> SpreadDecision { get; set; }
    public Nullable<long> FullProcentualProfitDecision { get; set; }
    public Nullable<long> PositiveOrdersCountDecision { get; set; }
    public Nullable<long> BestSumProfitDecision { get; set; }
    public Nullable<long> VolumeDecision { get; set; }
    public Nullable<long> BarsPerOrdersDecision { get; set; }
}