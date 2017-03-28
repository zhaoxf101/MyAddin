using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PostPidSet))]
#if Dev
    [RunLocal]
#endif

	public class FI_PostPidSet:ReadOnlyBase<FI_PostPidSet>
    {
        #region Business Methods

		
        public string PostPidSet
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

		public static FI_PostPidSet Create()
        {
            return EF.DataPortal.Create<FI_PostPidSet>();
        }

		public static FI_PostPidSet Fetch(System.Linq.Expressions.Expression<Func<FI_PostPidSet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PostPidSet>(exp,values);
            return EF.DataPortal.Fetch<FI_PostPidSet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PostPidSets))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PostPidSets:ReadOnlyListBase<FI_PostPidSets,FI_PostPidSet>
    {
        #region Factory Methods

        public static FI_PostPidSets Fetch()
        {
            return EF.DataPortal.Fetch<FI_PostPidSets>();
        }

		public static FI_PostPidSets Fetch(System.Linq.Expressions.Expression<Func<FI_PostPidSet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PostPidSet>(exp,values);
            return EF.DataPortal.Fetch<FI_PostPidSets>(lambda);
		}

		public static FI_PostPidSets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PostPidSets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PostPidSets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PostPidSet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PostPidSets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PostPidSet>(exp,values)});
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
