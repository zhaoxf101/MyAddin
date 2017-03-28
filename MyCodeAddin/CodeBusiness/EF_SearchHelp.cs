using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SearchHelp))]
#if Dev
    [RunLocal]
#endif

	public class EF_SearchHelp:ReadOnlyBase<EF_SearchHelp>
    {
        #region Business Methods

		
        public string SHlpName
        {
            get ;
            set ;
        }

		
        public string RowStatus
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

		public static EF_SearchHelp Create()
        {
            return EF.DataPortal.Create<EF_SearchHelp>();
        }

		public static EF_SearchHelp Fetch(System.Linq.Expressions.Expression<Func<EF_SearchHelp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SearchHelp>(exp,values);
            return EF.DataPortal.Fetch<EF_SearchHelp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SearchHelps))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SearchHelps:ReadOnlyListBase<EF_SearchHelps,EF_SearchHelp>
    {
        #region Factory Methods

        public static EF_SearchHelps Fetch()
        {
            return EF.DataPortal.Fetch<EF_SearchHelps>();
        }

		public static EF_SearchHelps Fetch(System.Linq.Expressions.Expression<Func<EF_SearchHelp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SearchHelp>(exp,values);
            return EF.DataPortal.Fetch<EF_SearchHelps>(lambda);
		}

		public static EF_SearchHelps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SearchHelps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SearchHelps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SearchHelp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SearchHelps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SearchHelp>(exp,values)});
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
