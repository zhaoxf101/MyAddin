using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusTravel))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusTravel:ReadOnlyBase<FI_ExpBusTravel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public int TravelRowId
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string UserId
        {
            get ;
            set ;
        }

		
        public string UserType
        {
            get ;
            set ;
        }

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public DateTime? StartTime
        {
            get ;
            set ;
        }

		
        public DateTime? EndTime
        {
            get ;
            set ;
        }

		
        public string StartLocation
        {
            get ;
            set ;
        }

		
        public string EndLoaction
        {
            get ;
            set ;
        }

		
        public decimal TravelDays
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusTravel Create()
        {
            return EF.DataPortal.Create<FI_ExpBusTravel>();
        }

		public static FI_ExpBusTravel Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusTravel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusTravel>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusTravel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusTravels))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusTravels:ReadOnlyListBase<FI_ExpBusTravels,FI_ExpBusTravel>
    {
        #region Factory Methods

        public static FI_ExpBusTravels Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravels>();
        }

		public static FI_ExpBusTravels Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusTravel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusTravel>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusTravels>(lambda);
		}

		public static FI_ExpBusTravels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusTravels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusTravel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusTravel>(exp,values)});
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
