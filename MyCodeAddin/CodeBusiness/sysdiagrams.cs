using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(sysdiagrams))]
#if Dev
    [RunLocal]
#endif

	public class sysdiagrams:ReadOnlyBase<sysdiagrams>
    {
        #region Business Methods

		
        public string name
        {
            get ;
            set ;
        }

		
        public int principal_id
        {
            get ;
            set ;
        }

		
        public int diagram_id
        {
            get ;
            set ;
        }

		
        public int? version
        {
            get ;
            set ;
        }

		
        public varbinary? definition
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static sysdiagrams Create()
        {
            return EF.DataPortal.Create<sysdiagrams>();
        }

		public static sysdiagrams Fetch(System.Linq.Expressions.Expression<Func<sysdiagrams, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<sysdiagrams>(exp,values);
            return EF.DataPortal.Fetch<sysdiagrams>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(sysdiagramss))]
#if Dev
    [RunLocal]
#endif
	
	public class sysdiagramss:ReadOnlyListBase<sysdiagramss,sysdiagrams>
    {
        #region Factory Methods

        public static sysdiagramss Fetch()
        {
            return EF.DataPortal.Fetch<sysdiagramss>();
        }

		public static sysdiagramss Fetch(System.Linq.Expressions.Expression<Func<sysdiagrams, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<sysdiagrams>(exp,values);
            return EF.DataPortal.Fetch<sysdiagramss>(lambda);
		}

		public static sysdiagramss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<sysdiagramss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static sysdiagramss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<sysdiagrams, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<sysdiagramss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<sysdiagrams>(exp,values)});
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
