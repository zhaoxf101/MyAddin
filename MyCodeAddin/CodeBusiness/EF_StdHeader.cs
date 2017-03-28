using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_StdHeader))]
#if Dev
    [RunLocal]
#endif

	public class EF_StdHeader:ReadOnlyBase<EF_StdHeader>
    {
        #region Business Methods

		
        public string SetStd
        {
            get ;
            set ;
        }

		
        public string SetUnit
        {
            get ;
            set ;
        }

		
        public string SetCode
        {
            get ;
            set ;
        }

		
        public string SetName
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_StdHeader Create()
        {
            return EF.DataPortal.Create<EF_StdHeader>();
        }

		public static EF_StdHeader Fetch(System.Linq.Expressions.Expression<Func<EF_StdHeader, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_StdHeader>(exp,values);
            return EF.DataPortal.Fetch<EF_StdHeader>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_StdHeaders))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_StdHeaders:ReadOnlyListBase<EF_StdHeaders,EF_StdHeader>
    {
        #region Factory Methods

        public static EF_StdHeaders Fetch()
        {
            return EF.DataPortal.Fetch<EF_StdHeaders>();
        }

		public static EF_StdHeaders Fetch(System.Linq.Expressions.Expression<Func<EF_StdHeader, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_StdHeader>(exp,values);
            return EF.DataPortal.Fetch<EF_StdHeaders>(lambda);
		}

		public static EF_StdHeaders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_StdHeaders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_StdHeaders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_StdHeader, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_StdHeaders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_StdHeader>(exp,values)});
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
