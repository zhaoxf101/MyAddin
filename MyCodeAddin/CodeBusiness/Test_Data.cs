using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Test_Data))]
#if Dev
    [RunLocal]
#endif

	public class Test_Data:ReadOnlyBase<Test_Data>
    {
        #region Business Methods

		
        public string DataCode
        {
            get ;
            set ;
        }

		
        public string DataName
        {
            get ;
            set ;
        }

		
        public decimal? DataAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Test_Data Create()
        {
            return EF.DataPortal.Create<Test_Data>();
        }

		public static Test_Data Fetch(System.Linq.Expressions.Expression<Func<Test_Data, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Test_Data>(exp,values);
            return EF.DataPortal.Fetch<Test_Data>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Test_Datas))]
#if Dev
    [RunLocal]
#endif
	
	public class Test_Datas:ReadOnlyListBase<Test_Datas,Test_Data>
    {
        #region Factory Methods

        public static Test_Datas Fetch()
        {
            return EF.DataPortal.Fetch<Test_Datas>();
        }

		public static Test_Datas Fetch(System.Linq.Expressions.Expression<Func<Test_Data, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Test_Data>(exp,values);
            return EF.DataPortal.Fetch<Test_Datas>(lambda);
		}

		public static Test_Datas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Test_Datas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Test_Datas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Test_Data, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Test_Datas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Test_Data>(exp,values)});
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
