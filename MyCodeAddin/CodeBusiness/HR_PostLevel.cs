using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_PostLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_PostLevel:ReadOnlyBase<HR_PostLevel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PostLevel
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PostCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_PostLevel Create()
        {
            return EF.DataPortal.Create<HR_PostLevel>();
        }

		public static HR_PostLevel Fetch(System.Linq.Expressions.Expression<Func<HR_PostLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_PostLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_PostLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_PostLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_PostLevels:ReadOnlyListBase<HR_PostLevels,HR_PostLevel>
    {
        #region Factory Methods

        public static HR_PostLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_PostLevels>();
        }

		public static HR_PostLevels Fetch(System.Linq.Expressions.Expression<Func<HR_PostLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_PostLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_PostLevels>(lambda);
		}

		public static HR_PostLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_PostLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_PostLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_PostLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_PostLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_PostLevel>(exp,values)});
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
