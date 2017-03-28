using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_GetArea))]
#if Dev
    [RunLocal]
#endif

	public class HR_GetArea:ReadOnlyBase<HR_GetArea>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GetAreaCode
        {
            get ;
            set ;
        }

		
        public string StaffTypeCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_GetArea Create()
        {
            return EF.DataPortal.Create<HR_GetArea>();
        }

		public static HR_GetArea Fetch(System.Linq.Expressions.Expression<Func<HR_GetArea, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_GetArea>(exp,values);
            return EF.DataPortal.Fetch<HR_GetArea>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_GetAreas))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_GetAreas:ReadOnlyListBase<HR_GetAreas,HR_GetArea>
    {
        #region Factory Methods

        public static HR_GetAreas Fetch()
        {
            return EF.DataPortal.Fetch<HR_GetAreas>();
        }

		public static HR_GetAreas Fetch(System.Linq.Expressions.Expression<Func<HR_GetArea, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_GetArea>(exp,values);
            return EF.DataPortal.Fetch<HR_GetAreas>(lambda);
		}

		public static HR_GetAreas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_GetAreas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_GetAreas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_GetArea, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_GetAreas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_GetArea>(exp,values)});
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
