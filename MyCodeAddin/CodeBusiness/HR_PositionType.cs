using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_PositionType))]
#if Dev
    [RunLocal]
#endif

	public class HR_PositionType:ReadOnlyBase<HR_PositionType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PositionType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string Mark
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_PositionType Create()
        {
            return EF.DataPortal.Create<HR_PositionType>();
        }

		public static HR_PositionType Fetch(System.Linq.Expressions.Expression<Func<HR_PositionType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_PositionType>(exp,values);
            return EF.DataPortal.Fetch<HR_PositionType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_PositionTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_PositionTypes:ReadOnlyListBase<HR_PositionTypes,HR_PositionType>
    {
        #region Factory Methods

        public static HR_PositionTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_PositionTypes>();
        }

		public static HR_PositionTypes Fetch(System.Linq.Expressions.Expression<Func<HR_PositionType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_PositionType>(exp,values);
            return EF.DataPortal.Fetch<HR_PositionTypes>(lambda);
		}

		public static HR_PositionTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_PositionTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_PositionTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_PositionType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_PositionTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_PositionType>(exp,values)});
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
