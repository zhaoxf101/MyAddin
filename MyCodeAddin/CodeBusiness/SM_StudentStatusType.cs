using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StudentStatusType))]
#if Dev
    [RunLocal]
#endif

	public class SM_StudentStatusType:ReadOnlyBase<SM_StudentStatusType>
    {
        #region Business Methods

		
        public string StudentStatusTypeCode
        {
            get ;
            set ;
        }

		
        public string StudentStatusTypeName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_StudentStatusType Create()
        {
            return EF.DataPortal.Create<SM_StudentStatusType>();
        }

		public static SM_StudentStatusType Fetch(System.Linq.Expressions.Expression<Func<SM_StudentStatusType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentStatusType>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentStatusType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StudentStatusTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StudentStatusTypes:ReadOnlyListBase<SM_StudentStatusTypes,SM_StudentStatusType>
    {
        #region Factory Methods

        public static SM_StudentStatusTypes Fetch()
        {
            return EF.DataPortal.Fetch<SM_StudentStatusTypes>();
        }

		public static SM_StudentStatusTypes Fetch(System.Linq.Expressions.Expression<Func<SM_StudentStatusType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentStatusType>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentStatusTypes>(lambda);
		}

		public static SM_StudentStatusTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StudentStatusTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StudentStatusTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StudentStatusType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StudentStatusTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StudentStatusType>(exp,values)});
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
