using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_PositionLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_PositionLevel:ReadOnlyBase<HR_PositionLevel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PositionLevel
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

		public static HR_PositionLevel Create()
        {
            return EF.DataPortal.Create<HR_PositionLevel>();
        }

		public static HR_PositionLevel Fetch(System.Linq.Expressions.Expression<Func<HR_PositionLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_PositionLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_PositionLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_PositionLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_PositionLevels:ReadOnlyListBase<HR_PositionLevels,HR_PositionLevel>
    {
        #region Factory Methods

        public static HR_PositionLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_PositionLevels>();
        }

		public static HR_PositionLevels Fetch(System.Linq.Expressions.Expression<Func<HR_PositionLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_PositionLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_PositionLevels>(lambda);
		}

		public static HR_PositionLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_PositionLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_PositionLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_PositionLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_PositionLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_PositionLevel>(exp,values)});
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
