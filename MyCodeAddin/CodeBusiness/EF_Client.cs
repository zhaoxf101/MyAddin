using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Client))]
#if Dev
    [RunLocal]
#endif

	public class EF_Client:ReadOnlyBase<EF_Client>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string CType
        {
            get ;
            set ;
        }

		
        public string City
        {
            get ;
            set ;
        }

		
        public string Address
        {
            get ;
            set ;
        }

		
        public string Currency
        {
            get ;
            set ;
        }

		
        public string AccChart
        {
            get ;
            set ;
        }

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string AccYearSet
        {
            get ;
            set ;
        }

		
        public string PostPidSet
        {
            get ;
            set ;
        }

		
        public string FieldSet
        {
            get ;
            set ;
        }

		
        public string AccStdLev
        {
            get ;
            set ;
        }

		
        public bool FIAccingX
        {
            get ;
            set ;
        }

		
        public bool NegPostX
        {
            get ;
            set ;
        }

		
        public bool OnlinePayX
        {
            get ;
            set ;
        }

		
        public bool VApprX
        {
            get ;
            set ;
        }

		
        public decimal VApprLev
        {
            get ;
            set ;
        }

		
        public int BarPrefixLen
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

		public static EF_Client Create()
        {
            return EF.DataPortal.Create<EF_Client>();
        }

		public static EF_Client Fetch(System.Linq.Expressions.Expression<Func<EF_Client, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Client>(exp,values);
            return EF.DataPortal.Fetch<EF_Client>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Clients))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Clients:ReadOnlyListBase<EF_Clients,EF_Client>
    {
        #region Factory Methods

        public static EF_Clients Fetch()
        {
            return EF.DataPortal.Fetch<EF_Clients>();
        }

		public static EF_Clients Fetch(System.Linq.Expressions.Expression<Func<EF_Client, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Client>(exp,values);
            return EF.DataPortal.Fetch<EF_Clients>(lambda);
		}

		public static EF_Clients Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Clients>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Clients Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Client, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Clients>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Client>(exp,values)});
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
