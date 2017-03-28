using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TaxAdj))]
#if Dev
    [RunLocal]
#endif

	public class FI_TaxAdj:ReadOnlyBase<FI_TaxAdj>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TaxAdjCode
        {
            get ;
            set ;
        }

		
        public string TaxAdjText
        {
            get ;
            set ;
        }

		
        public bool IsClear
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appovel
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string AccDateTime
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string VouchText
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

		public static FI_TaxAdj Create()
        {
            return EF.DataPortal.Create<FI_TaxAdj>();
        }

		public static FI_TaxAdj Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdj>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TaxAdjs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TaxAdjs:ReadOnlyListBase<FI_TaxAdjs,FI_TaxAdj>
    {
        #region Factory Methods

        public static FI_TaxAdjs Fetch()
        {
            return EF.DataPortal.Fetch<FI_TaxAdjs>();
        }

		public static FI_TaxAdjs Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdj>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdjs>(lambda);
		}

		public static FI_TaxAdjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TaxAdjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TaxAdj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TaxAdj>(exp,values)});
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
