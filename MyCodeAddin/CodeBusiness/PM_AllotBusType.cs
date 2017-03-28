using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotBusType))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotBusType:ReadOnlyBase<PM_AllotBusType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeCode
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeName
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AllotGrp
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string IncDetTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsTuiAllo
        {
            get ;
            set ;
        }

		
        public bool IsInvChk
        {
            get ;
            set ;
        }

		
        public bool IsTaxChk
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string IncAccCode
        {
            get ;
            set ;
        }

		
        public string AllotAccCls
        {
            get ;
            set ;
        }

		
        public bool IsReturn
        {
            get ;
            set ;
        }

		
        public bool IsPending
        {
            get ;
            set ;
        }

		
        public bool IsDis
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotBusType Create()
        {
            return EF.DataPortal.Create<PM_AllotBusType>();
        }

		public static PM_AllotBusType Fetch(System.Linq.Expressions.Expression<Func<PM_AllotBusType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotBusType>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotBusType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotBusTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotBusTypes:ReadOnlyListBase<PM_AllotBusTypes,PM_AllotBusType>
    {
        #region Factory Methods

        public static PM_AllotBusTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotBusTypes>();
        }

		public static PM_AllotBusTypes Fetch(System.Linq.Expressions.Expression<Func<PM_AllotBusType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotBusType>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotBusTypes>(lambda);
		}

		public static PM_AllotBusTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotBusTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotBusTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotBusType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotBusTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotBusType>(exp,values)});
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
