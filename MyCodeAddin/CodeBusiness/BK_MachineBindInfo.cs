using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(BK_MachineBindInfo))]
#if Dev
    [RunLocal]
#endif

	public class BK_MachineBindInfo:ReadOnlyBase<BK_MachineBindInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string MachineId
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string PersonName
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsCanPay
        {
            get ;
            set ;
        }

		
        public bool IsCanView
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public bool IsSetPass
        {
            get ;
            set ;
        }

		
        public string PayPass
        {
            get ;
            set ;
        }

		
        public bool IsAllotSet
        {
            get ;
            set ;
        }

		
        public bool IsCtrlTime
        {
            get ;
            set ;
        }

		
        public string StartTime
        {
            get ;
            set ;
        }

		
        public string EndTime
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static BK_MachineBindInfo Create()
        {
            return EF.DataPortal.Create<BK_MachineBindInfo>();
        }

		public static BK_MachineBindInfo Fetch(System.Linq.Expressions.Expression<Func<BK_MachineBindInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<BK_MachineBindInfo>(exp,values);
            return EF.DataPortal.Fetch<BK_MachineBindInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(BK_MachineBindInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class BK_MachineBindInfos:ReadOnlyListBase<BK_MachineBindInfos,BK_MachineBindInfo>
    {
        #region Factory Methods

        public static BK_MachineBindInfos Fetch()
        {
            return EF.DataPortal.Fetch<BK_MachineBindInfos>();
        }

		public static BK_MachineBindInfos Fetch(System.Linq.Expressions.Expression<Func<BK_MachineBindInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<BK_MachineBindInfo>(exp,values);
            return EF.DataPortal.Fetch<BK_MachineBindInfos>(lambda);
		}

		public static BK_MachineBindInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<BK_MachineBindInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static BK_MachineBindInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<BK_MachineBindInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<BK_MachineBindInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<BK_MachineBindInfo>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
