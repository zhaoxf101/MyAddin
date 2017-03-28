using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccGrp))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccGrp:ReadOnlyBase<FI_AccGrp>
    {
        #region Business Methods

		
        public string AccChart
        {
            get ;
            set ;
        }

		
        public string AccGrp
        {
            get ;
            set ;
        }

		
        public string StartAcc
        {
            get ;
            set ;
        }

		
        public string EndAcc
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static FI_AccGrp Create()
        {
            return EF.DataPortal.Create<FI_AccGrp>();
        }

		public static FI_AccGrp Fetch(System.Linq.Expressions.Expression<Func<FI_AccGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_AccGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccGrps:ReadOnlyListBase<FI_AccGrps,FI_AccGrp>
    {
        #region Factory Methods

        public static FI_AccGrps Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccGrps>();
        }

		public static FI_AccGrps Fetch(System.Linq.Expressions.Expression<Func<FI_AccGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_AccGrps>(lambda);
		}

		public static FI_AccGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccGrp>(exp,values)});
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
