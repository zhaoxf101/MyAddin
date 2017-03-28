using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Test_UsGroup))]
#if Dev
    [RunLocal]
#endif

	public class Test_UsGroup:ReadOnlyBase<Test_UsGroup>
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

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
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

		public static Test_UsGroup Create()
        {
            return EF.DataPortal.Create<Test_UsGroup>();
        }

		public static Test_UsGroup Fetch(System.Linq.Expressions.Expression<Func<Test_UsGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Test_UsGroup>(exp,values);
            return EF.DataPortal.Fetch<Test_UsGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Test_UsGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class Test_UsGroups:ReadOnlyListBase<Test_UsGroups,Test_UsGroup>
    {
        #region Factory Methods

        public static Test_UsGroups Fetch()
        {
            return EF.DataPortal.Fetch<Test_UsGroups>();
        }

		public static Test_UsGroups Fetch(System.Linq.Expressions.Expression<Func<Test_UsGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Test_UsGroup>(exp,values);
            return EF.DataPortal.Fetch<Test_UsGroups>(lambda);
		}

		public static Test_UsGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Test_UsGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Test_UsGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Test_UsGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Test_UsGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Test_UsGroup>(exp,values)});
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
