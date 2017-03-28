using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjLeader))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjLeader:ReadOnlyBase<PM_ProjLeader>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string LPersonId
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

		public static PM_ProjLeader Create()
        {
            return EF.DataPortal.Create<PM_ProjLeader>();
        }

		public static PM_ProjLeader Fetch(System.Linq.Expressions.Expression<Func<PM_ProjLeader, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjLeader>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjLeader>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjLeaders))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjLeaders:ReadOnlyListBase<PM_ProjLeaders,PM_ProjLeader>
    {
        #region Factory Methods

        public static PM_ProjLeaders Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjLeaders>();
        }

		public static PM_ProjLeaders Fetch(System.Linq.Expressions.Expression<Func<PM_ProjLeader, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjLeader>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjLeaders>(lambda);
		}

		public static PM_ProjLeaders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjLeaders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjLeaders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjLeader, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjLeaders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjLeader>(exp,values)});
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
