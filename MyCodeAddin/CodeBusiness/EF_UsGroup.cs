using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_UsGroup))]
#if Dev
    [RunLocal]
#endif

	public class EF_UsGroup:ReadOnlyBase<EF_UsGroup>
    {
        #region Business Methods

		
        public string UserGroup
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

		public static EF_UsGroup Create()
        {
            return EF.DataPortal.Create<EF_UsGroup>();
        }

		public static EF_UsGroup Fetch(System.Linq.Expressions.Expression<Func<EF_UsGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_UsGroup>(exp,values);
            return EF.DataPortal.Fetch<EF_UsGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_UsGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_UsGroups:ReadOnlyListBase<EF_UsGroups,EF_UsGroup>
    {
        #region Factory Methods

        public static EF_UsGroups Fetch()
        {
            return EF.DataPortal.Fetch<EF_UsGroups>();
        }

		public static EF_UsGroups Fetch(System.Linq.Expressions.Expression<Func<EF_UsGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_UsGroup>(exp,values);
            return EF.DataPortal.Fetch<EF_UsGroups>(lambda);
		}

		public static EF_UsGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_UsGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_UsGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_UsGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_UsGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_UsGroup>(exp,values)});
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
