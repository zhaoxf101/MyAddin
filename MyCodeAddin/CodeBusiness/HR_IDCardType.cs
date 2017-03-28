using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_IDCardType))]
#if Dev
    [RunLocal]
#endif

	public class HR_IDCardType:ReadOnlyBase<HR_IDCardType>
    {
        #region Business Methods

		
        public string IDCardTypeCode
        {
            get ;
            set ;
        }

		
        public string IDCardTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_IDCardType Create()
        {
            return EF.DataPortal.Create<HR_IDCardType>();
        }

		public static HR_IDCardType Fetch(System.Linq.Expressions.Expression<Func<HR_IDCardType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_IDCardType>(exp,values);
            return EF.DataPortal.Fetch<HR_IDCardType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_IDCardTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_IDCardTypes:ReadOnlyListBase<HR_IDCardTypes,HR_IDCardType>
    {
        #region Factory Methods

        public static HR_IDCardTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_IDCardTypes>();
        }

		public static HR_IDCardTypes Fetch(System.Linq.Expressions.Expression<Func<HR_IDCardType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_IDCardType>(exp,values);
            return EF.DataPortal.Fetch<HR_IDCardTypes>(lambda);
		}

		public static HR_IDCardTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_IDCardTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_IDCardTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_IDCardType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_IDCardTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_IDCardType>(exp,values)});
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
