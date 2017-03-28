using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zTemp))]
#if Dev
    [RunLocal]
#endif

	public class zTemp:ReadOnlyBase<zTemp>
    {
        #region Business Methods

		
        public string sno
        {
            get ;
            set ;
        }

		
        public string sname
        {
            get ;
            set ;
        }

		
        public string classid
        {
            get ;
            set ;
        }

		
        public string classname
        {
            get ;
            set ;
        }

		
        public string depid
        {
            get ;
            set ;
        }

		
        public string depname
        {
            get ;
            set ;
        }

		
        public string spcid
        {
            get ;
            set ;
        }

		
        public string spcname
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zTemp Create()
        {
            return EF.DataPortal.Create<zTemp>();
        }

		public static zTemp Fetch(System.Linq.Expressions.Expression<Func<zTemp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zTemp>(exp,values);
            return EF.DataPortal.Fetch<zTemp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zTemps))]
#if Dev
    [RunLocal]
#endif
	
	public class zTemps:ReadOnlyListBase<zTemps,zTemp>
    {
        #region Factory Methods

        public static zTemps Fetch()
        {
            return EF.DataPortal.Fetch<zTemps>();
        }

		public static zTemps Fetch(System.Linq.Expressions.Expression<Func<zTemp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zTemp>(exp,values);
            return EF.DataPortal.Fetch<zTemps>(lambda);
		}

		public static zTemps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zTemps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zTemps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zTemp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zTemps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zTemp>(exp,values)});
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
