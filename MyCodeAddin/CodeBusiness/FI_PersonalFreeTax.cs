using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PersonalFreeTax))]
#if Dev
    [RunLocal]
#endif

	public class FI_PersonalFreeTax:ReadOnlyBase<FI_PersonalFreeTax>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public long RowID
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public decimal FreeTax
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PersonalFreeTax Create()
        {
            return EF.DataPortal.Create<FI_PersonalFreeTax>();
        }

		public static FI_PersonalFreeTax Fetch(System.Linq.Expressions.Expression<Func<FI_PersonalFreeTax, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PersonalFreeTax>(exp,values);
            return EF.DataPortal.Fetch<FI_PersonalFreeTax>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PersonalFreeTaxs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PersonalFreeTaxs:ReadOnlyListBase<FI_PersonalFreeTaxs,FI_PersonalFreeTax>
    {
        #region Factory Methods

        public static FI_PersonalFreeTaxs Fetch()
        {
            return EF.DataPortal.Fetch<FI_PersonalFreeTaxs>();
        }

		public static FI_PersonalFreeTaxs Fetch(System.Linq.Expressions.Expression<Func<FI_PersonalFreeTax, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PersonalFreeTax>(exp,values);
            return EF.DataPortal.Fetch<FI_PersonalFreeTaxs>(lambda);
		}

		public static FI_PersonalFreeTaxs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PersonalFreeTaxs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PersonalFreeTaxs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PersonalFreeTax, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PersonalFreeTaxs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PersonalFreeTax>(exp,values)});
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
