using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusPProjEco))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusPProjEco:ReadOnlyBase<FI_ExpBusPProjEco>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string PProjCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string PFundEcoType
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusPProjEco Create()
        {
            return EF.DataPortal.Create<FI_ExpBusPProjEco>();
        }

		public static FI_ExpBusPProjEco Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusPProjEco, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusPProjEco>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusPProjEco>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusPProjEcos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusPProjEcos:ReadOnlyListBase<FI_ExpBusPProjEcos,FI_ExpBusPProjEco>
    {
        #region Factory Methods

        public static FI_ExpBusPProjEcos Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusPProjEcos>();
        }

		public static FI_ExpBusPProjEcos Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusPProjEco, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusPProjEco>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusPProjEcos>(lambda);
		}

		public static FI_ExpBusPProjEcos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusPProjEcos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusPProjEcos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusPProjEco, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusPProjEcos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusPProjEco>(exp,values)});
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
