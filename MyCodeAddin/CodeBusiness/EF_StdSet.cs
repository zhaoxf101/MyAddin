using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_StdSet))]
#if Dev
    [RunLocal]
#endif

	public class EF_StdSet:ReadOnlyBase<EF_StdSet>
    {
        #region Business Methods

		
        public string SetStd
        {
            get ;
            set ;
        }

		
        public string SetUnit
        {
            get ;
            set ;
        }

		
        public string SetClass
        {
            get ;
            set ;
        }

		
        public string RootId
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

		public static EF_StdSet Create()
        {
            return EF.DataPortal.Create<EF_StdSet>();
        }

		public static EF_StdSet Fetch(System.Linq.Expressions.Expression<Func<EF_StdSet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_StdSet>(exp,values);
            return EF.DataPortal.Fetch<EF_StdSet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_StdSets))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_StdSets:ReadOnlyListBase<EF_StdSets,EF_StdSet>
    {
        #region Factory Methods

        public static EF_StdSets Fetch()
        {
            return EF.DataPortal.Fetch<EF_StdSets>();
        }

		public static EF_StdSets Fetch(System.Linq.Expressions.Expression<Func<EF_StdSet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_StdSet>(exp,values);
            return EF.DataPortal.Fetch<EF_StdSets>(lambda);
		}

		public static EF_StdSets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_StdSets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_StdSets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_StdSet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_StdSets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_StdSet>(exp,values)});
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
