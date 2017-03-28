using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Bank))]
#if Dev
    [RunLocal]
#endif

	public class FI_Bank:ReadOnlyBase<FI_Bank>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Bank
        {
            get ;
            set ;
        }

		
        public string BkSim
        {
            get ;
            set ;
        }

		
        public string BkName
        {
            get ;
            set ;
        }

		
        public string DepoName
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string TaxId
        {
            get ;
            set ;
        }

		
        public string Name
        {
            get ;
            set ;
        }

		
        public string ADR
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
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

		public static FI_Bank Create()
        {
            return EF.DataPortal.Create<FI_Bank>();
        }

		public static FI_Bank Fetch(System.Linq.Expressions.Expression<Func<FI_Bank, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Bank>(exp,values);
            return EF.DataPortal.Fetch<FI_Bank>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Banks))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Banks:ReadOnlyListBase<FI_Banks,FI_Bank>
    {
        #region Factory Methods

        public static FI_Banks Fetch()
        {
            return EF.DataPortal.Fetch<FI_Banks>();
        }

		public static FI_Banks Fetch(System.Linq.Expressions.Expression<Func<FI_Bank, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Bank>(exp,values);
            return EF.DataPortal.Fetch<FI_Banks>(lambda);
		}

		public static FI_Banks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Banks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Banks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Bank, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Banks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Bank>(exp,values)});
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
