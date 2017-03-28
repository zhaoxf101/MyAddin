using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SociSecImportDetail))]
#if Dev
    [RunLocal]
#endif

	public class HR_SociSecImportDetail:ReadOnlyBase<HR_SociSecImportDetail>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SociSecCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string SociSecItemCode
        {
            get ;
            set ;
        }

		
        public string SociSecItemName
        {
            get ;
            set ;
        }

		
        public decimal SociSecAmt
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public int TaxPeriod
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string Staff
        {
            get ;
            set ;
        }

		
        public string UType
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

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SociSecImportDetail Create()
        {
            return EF.DataPortal.Create<HR_SociSecImportDetail>();
        }

		public static HR_SociSecImportDetail Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecImportDetail, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecImportDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecImportDetail>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SociSecImportDetails))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SociSecImportDetails:ReadOnlyListBase<HR_SociSecImportDetails,HR_SociSecImportDetail>
    {
        #region Factory Methods

        public static HR_SociSecImportDetails Fetch()
        {
            return EF.DataPortal.Fetch<HR_SociSecImportDetails>();
        }

		public static HR_SociSecImportDetails Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecImportDetail, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecImportDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecImportDetails>(lambda);
		}

		public static HR_SociSecImportDetails Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SociSecImportDetails>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SociSecImportDetails Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SociSecImportDetail, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SociSecImportDetails>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SociSecImportDetail>(exp,values)});
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
