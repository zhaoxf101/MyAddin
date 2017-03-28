using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ComGrp))]
#if Dev
    [RunLocal]
#endif

	public class PM_ComGrp:ReadOnlyBase<PM_ComGrp>
    {
        #region Business Methods

		
        public string ComGrpCode
        {
            get ;
            set ;
        }

		
        public string ComGrpName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_ComGrp Create()
        {
            return EF.DataPortal.Create<PM_ComGrp>();
        }

		public static PM_ComGrp Fetch(System.Linq.Expressions.Expression<Func<PM_ComGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ComGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_ComGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ComGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ComGrps:ReadOnlyListBase<PM_ComGrps,PM_ComGrp>
    {
        #region Factory Methods

        public static PM_ComGrps Fetch()
        {
            return EF.DataPortal.Fetch<PM_ComGrps>();
        }

		public static PM_ComGrps Fetch(System.Linq.Expressions.Expression<Func<PM_ComGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ComGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_ComGrps>(lambda);
		}

		public static PM_ComGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ComGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ComGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ComGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ComGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ComGrp>(exp,values)});
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
