using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_WorkersLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_WorkersLevel:ReadOnlyBase<HR_WorkersLevel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkersLevel
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_WorkersLevel Create()
        {
            return EF.DataPortal.Create<HR_WorkersLevel>();
        }

		public static HR_WorkersLevel Fetch(System.Linq.Expressions.Expression<Func<HR_WorkersLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_WorkersLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_WorkersLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_WorkersLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_WorkersLevels:ReadOnlyListBase<HR_WorkersLevels,HR_WorkersLevel>
    {
        #region Factory Methods

        public static HR_WorkersLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_WorkersLevels>();
        }

		public static HR_WorkersLevels Fetch(System.Linq.Expressions.Expression<Func<HR_WorkersLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_WorkersLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_WorkersLevels>(lambda);
		}

		public static HR_WorkersLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_WorkersLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_WorkersLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_WorkersLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_WorkersLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_WorkersLevel>(exp,values)});
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
