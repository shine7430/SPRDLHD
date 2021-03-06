namespace Spreadtrum.LHD.Entity.Lots
{
    using System;
    using System.Collections.Generic;

    public class Lot
    {
        private string _AutoJudgeResult = string.Empty;
        private int _Bin1;
        private int _Bin10;
        private int _Bin2;
        private int _Bin3;
        private int _Bin4;
        private int _Bin5;
        private int _Bin6;
        private int _Bin7;
        private int _Bin8;
        private int _Bin9;
        private DateTime _CompletionDate;
        private DateTime _CreateTime;
        private string _CustomerLotID = string.Empty;
        private int _Damage;
        private string _DeviceCode = string.Empty;
        private string _DeviceName = string.Empty;
        private string _Die1CP = string.Empty;
        private string _Die1LotNO = string.Empty;
        private string _Die2CP = string.Empty;
        private string _Die2LotNO = string.Empty;
        private string _Die3CP = string.Empty;
        private string _Die3LotNO = string.Empty;
        private string _Die4CP = string.Empty;
        private string _Die4LotNO = string.Empty;
        private string _HoldReason = string.Empty;
        private string _ID = string.Empty;
        private string _LastOperator = string.Empty;
        private string _LBNO = string.Empty;
        private int _Loss;
        private string _LotID = string.Empty;
        private string _LotNO = string.Empty;
        private string _LotType = string.Empty;
        private bool _ManualHold = true;
        private DateTime _OperateTime;
        private string _OperateType = string.Empty;
        private string _OperatorID = string.Empty;
        private string _OperatorName = string.Empty;
        private double _OSRate;
        private bool _OtherBinDispose;
        private bool _OtherBinDisposeConfirmed;
        private DateTime _OtherBinDisposeConfirmTime;
        private int _PEDispose;
        private string _PEDisposeText = string.Empty;
        private DateTime _PEDisposeTime;
        private string _Platforms = string.Empty;
        private string _PreviousRecordID = string.Empty;
        private int _QADispose;
        private string _QADisposeText = string.Empty;
        private DateTime _QADisposeTime;
        private int _QtyIn;
        private int _RecordState;
        private string _RecordType = string.Empty;
        private int _RetestTimes;
        private int _SDStates;
        private int _SPRDDecision;
        private string _SPRDDecisionText = string.Empty;
        private string _Stage = string.Empty;
        private string _Status = string.Empty;
        private string _SubconLot = string.Empty;
        private IList<SWBin> _SWbins;
        private string _TesterID = string.Empty;
        private string _TestProgram = string.Empty;
        private DateTime _UpdateTime;
        private string _Url = string.Empty;
        private bool _VenderConfirmed = true;
        private string _VenderID = string.Empty;
        private string _VenderJudgeResult = string.Empty;
        private DateTime _VendorConfirmTime;
        private int _Version;
        private int _VersionID;
        private double _Yield;
        private int lastDecision;
        private string lotJudgementMessage = string.Empty;

        public void SetPEDispose(int dispose)
        {
            this.PEDispose = dispose;
        }

        public void SetQADispose(int dispose)
        {
            this.QADispose = dispose;
        }

        public string AutoJudgeResult
        {
            get
            {
                return this._AutoJudgeResult;
            }
            set
            {
                this._AutoJudgeResult = value;
            }
        }

        public int Bin1
        {
            get
            {
                return this._Bin1;
            }
            set
            {
                this._Bin1 = value;
            }
        }

        public int Bin10
        {
            get
            {
                return this._Bin10;
            }
            set
            {
                this._Bin10 = value;
            }
        }

        public int Bin2
        {
            get
            {
                return this._Bin2;
            }
            set
            {
                this._Bin2 = value;
            }
        }

        public int Bin3
        {
            get
            {
                return this._Bin3;
            }
            set
            {
                this._Bin3 = value;
            }
        }

        public int Bin4
        {
            get
            {
                return this._Bin4;
            }
            set
            {
                this._Bin4 = value;
            }
        }

        public int Bin5
        {
            get
            {
                return this._Bin5;
            }
            set
            {
                this._Bin5 = value;
            }
        }

        public int Bin6
        {
            get
            {
                return this._Bin6;
            }
            set
            {
                this._Bin6 = value;
            }
        }

        public int Bin7
        {
            get
            {
                return this._Bin7;
            }
            set
            {
                this._Bin7 = value;
            }
        }

        public int Bin8
        {
            get
            {
                return this._Bin8;
            }
            set
            {
                this._Bin8 = value;
            }
        }

        public int Bin9
        {
            get
            {
                return this._Bin9;
            }
            set
            {
                this._Bin9 = value;
            }
        }

        public DateTime CompletionDate
        {
            get
            {
                return this._CompletionDate;
            }
            set
            {
                this._CompletionDate = value;
            }
        }

        public DateTime CreateTime
        {
            get
            {
                return this._CreateTime;
            }
            set
            {
                this._CreateTime = value;
            }
        }

        public string CustomerLotID
        {
            get
            {
                return this._CustomerLotID;
            }
            set
            {
                this._CustomerLotID = value;
            }
        }

        public int Damage
        {
            get
            {
                return this._Damage;
            }
            set
            {
                this._Damage = value;
            }
        }

        public string DeviceCode
        {
            get
            {
                return this._DeviceCode;
            }
            set
            {
                this._DeviceCode = value;
            }
        }

        public string DeviceName
        {
            get
            {
                return this._DeviceName;
            }
            set
            {
                this._DeviceName = value;
            }
        }

        public string Die1CP
        {
            get
            {
                return this._Die1CP;
            }
            set
            {
                this._Die1CP = value;
            }
        }

        public string Die1LotNO
        {
            get
            {
                return this._Die1LotNO;
            }
            set
            {
                this._Die1LotNO = value;
            }
        }

        public string Die2CP
        {
            get
            {
                return this._Die2CP;
            }
            set
            {
                this._Die2CP = value;
            }
        }

        public string Die2LotNO
        {
            get
            {
                return this._Die2LotNO;
            }
            set
            {
                this._Die2LotNO = value;
            }
        }

        public string Die3CP
        {
            get
            {
                return this._Die3CP;
            }
            set
            {
                this._Die3CP = value;
            }
        }

        public string Die3LotNO
        {
            get
            {
                return this._Die3LotNO;
            }
            set
            {
                this._Die3LotNO = value;
            }
        }

        public string Die4CP
        {
            get
            {
                return this._Die4CP;
            }
            set
            {
                this._Die4CP = value;
            }
        }

        public string Die4LotNO
        {
            get
            {
                return this._Die4LotNO;
            }
            set
            {
                this._Die4LotNO = value;
            }
        }

        public string HoldReason
        {
            get
            {
                return this._HoldReason;
            }
            set
            {
                this._HoldReason = value;
            }
        }

        public string ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

        public int LastDecision
        {
            get
            {
                return this.lastDecision;
            }
            set
            {
                this.lastDecision = value;
            }
        }

        public string LastOperator
        {
            get
            {
                return this._LastOperator;
            }
            set
            {
                this._LastOperator = value;
            }
        }

        public string LBNO
        {
            get
            {
                return this._LBNO;
            }
            set
            {
                this._LBNO = value;
            }
        }

        public int Loss
        {
            get
            {
                return this._Loss;
            }
            set
            {
                this._Loss = value;
            }
        }

        public string LotID
        {
            get
            {
                return this._LotID;
            }
            set
            {
                this._LotID = value;
            }
        }

        public string LotJudgementMessage
        {
            get
            {
                return this.lotJudgementMessage;
            }
            set
            {
                this.lotJudgementMessage = value;
            }
        }

        public string LotNO
        {
            get
            {
                return this._LotNO;
            }
            set
            {
                this._LotNO = value;
            }
        }

        public string LotType
        {
            get
            {
                return this._LotType;
            }
            set
            {
                this._LotType = value;
            }
        }

        public bool ManualHold
        {
            get
            {
                return this._ManualHold;
            }
            set
            {
                this._ManualHold = value;
            }
        }

        public DateTime OperateTime
        {
            get
            {
                return this._OperateTime;
            }
            set
            {
                this._OperateTime = value;
            }
        }

        public string OperateType
        {
            get
            {
                return this._OperateType;
            }
            set
            {
                this._OperateType = value;
            }
        }

        public string OperatorID
        {
            get
            {
                return this._OperatorID;
            }
            set
            {
                this._OperatorID = value;
            }
        }

        public string OperatorName
        {
            get
            {
                return this._OperatorName;
            }
            set
            {
                this._OperatorName = value;
            }
        }

        public double OSRate
        {
            get
            {
                return this._OSRate;
            }
            set
            {
                this._OSRate = value;
            }
        }

        public bool OtherBinDispose
        {
            get
            {
                return this._OtherBinDispose;
            }
            set
            {
                this._OtherBinDispose = value;
            }
        }

        public bool OtherBinDisposeConfirmed
        {
            get
            {
                return this._OtherBinDisposeConfirmed;
            }
            set
            {
                this._OtherBinDisposeConfirmed = value;
            }
        }

        public DateTime OtherBinDisposeConfirmTime
        {
            get
            {
                return this._OtherBinDisposeConfirmTime;
            }
            set
            {
                this._OtherBinDisposeConfirmTime = value;
            }
        }

        public int PEDispose
        {
            get
            {
                return this._PEDispose;
            }
            set
            {
                this._PEDispose = value;
            }
        }

        public string PEDisposeText
        {
            get
            {
                return this._PEDisposeText;
            }
            set
            {
                this._PEDisposeText = value;
            }
        }

        public DateTime PEDisposeTime
        {
            get
            {
                return this._PEDisposeTime;
            }
            set
            {
                this._PEDisposeTime = value;
            }
        }

        public string Platforms
        {
            get
            {
                return this._Platforms;
            }
            set
            {
                this._Platforms = value;
            }
        }

        public string PreviousRecordID
        {
            get
            {
                return this._PreviousRecordID;
            }
            set
            {
                this._PreviousRecordID = value;
            }
        }

        public int QADispose
        {
            get
            {
                return this._QADispose;
            }
            set
            {
                this._QADispose = value;
            }
        }

        public string QADisposeText
        {
            get
            {
                return this._QADisposeText;
            }
            set
            {
                this._QADisposeText = value;
            }
        }

        public DateTime QADisposeTime
        {
            get
            {
                return this._QADisposeTime;
            }
            set
            {
                this._QADisposeTime = value;
            }
        }

        public int QtyIn
        {
            get
            {
                return this._QtyIn;
            }
            set
            {
                this._QtyIn = value;
            }
        }

        public int RecordState
        {
            get
            {
                return this._RecordState;
            }
            set
            {
                this._RecordState = value;
            }
        }

        public string RecordType
        {
            get
            {
                return this._RecordType;
            }
            set
            {
                this._RecordType = value;
            }
        }

        public int RetestTimes
        {
            get
            {
                return this._RetestTimes;
            }
            set
            {
                this._RetestTimes = value;
            }
        }

        public int SDStates
        {
            get
            {
                return this._SDStates;
            }
            set
            {
                this._SDStates = value;
            }
        }

        public int SPRDDecision
        {
            get
            {
                return this._SPRDDecision;
            }
            set
            {
                this._SPRDDecision = value;
            }
        }

        public string SPRDDecisionText
        {
            get
            {
                return this._SPRDDecisionText;
            }
            set
            {
                this._SPRDDecisionText = value;
            }
        }

        public string Stage
        {
            get
            {
                return this._Stage;
            }
            set
            {
                this._Stage = value;
            }
        }

        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
            }
        }

        public string SubconLot
        {
            get
            {
                return this._SubconLot;
            }
            set
            {
                this._SubconLot = value;
            }
        }

        public IList<SWBin> SWbins
        {
            get
            {
                return this._SWbins;
            }
            set
            {
                this._SWbins = value;
            }
        }

        public string TesterID
        {
            get
            {
                return this._TesterID;
            }
            set
            {
                this._TesterID = value;
            }
        }

        public string TestProgram
        {
            get
            {
                return this._TestProgram;
            }
            set
            {
                this._TestProgram = value;
            }
        }

        public DateTime UpdateTime
        {
            get
            {
                return this._UpdateTime;
            }
            set
            {
                this._UpdateTime = value;
            }
        }

        public string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                this._Url = value;
            }
        }

        public bool VenderConfirmed
        {
            get
            {
                return this._VenderConfirmed;
            }
            set
            {
                this._VenderConfirmed = value;
            }
        }

        public DateTime VenderConfirmTime
        {
            get
            {
                return this._VendorConfirmTime;
            }
            set
            {
                this._VendorConfirmTime = value;
            }
        }

        public string VenderID
        {
            get
            {
                return this._VenderID;
            }
            set
            {
                this._VenderID = value;
            }
        }

        public string VenderJudgeResult
        {
            get
            {
                return this._VenderJudgeResult;
            }
            set
            {
                this._VenderJudgeResult = value;
            }
        }

        public int Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this._Version = value;
            }
        }

        public int VersionID
        {
            get
            {
                return this._VersionID;
            }
            set
            {
                this._VersionID = value;
            }
        }

        public double Yield
        {
            get
            {
                return this._Yield;
            }
            set
            {
                this._Yield = value;
            }
        }
    }
}

