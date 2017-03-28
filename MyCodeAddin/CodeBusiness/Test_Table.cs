using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Test_Table))]
#if Dev
    [RunLocal]
#endif

	public class Test_Table:ReadOnlyBase<Test_Table>
    {
        #region Business Methods

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string ProjName
        {
            get ;
            set ;
        }

		
        public string TaskName
        {
            get ;
            set ;
        }

		
        public string FundName
        {
            get ;
            set ;
        }

		
        public TimeSpan? Test
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Test_Table Create()
        {
            return EF.DataPortal.Create<Test_Table>();
        }

		public static Test_Table Fetch(System.Linq.Expressions.Expression<Func<Test_Table, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Test_Table>(exp,values);
            return EF.DataPortal.Fetch<Test_Table>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Test_Tables))]
#if Dev
    [RunLocal]
#endif
	
	public class Test_Tables:ReadOnlyListBase<Test_Tables,Test_Table>
    {
        #region Factory Methods

        public static Test_Tables Fetch()
        {
            return EF.DataPortal.Fetch<Test_Tables>();
        }

		public static Test_Tables Fetch(System.Linq.Expressions.Expression<Func<Test_Table, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Test_Table>(exp,values);
            return EF.DataPortal.Fetch<Test_Tables>(lambda);
		}

		public static Test_Tables Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Test_Tables>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Test_Tables Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Test_Table, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Test_Tables>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Test_Table>(exp,values)});
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
