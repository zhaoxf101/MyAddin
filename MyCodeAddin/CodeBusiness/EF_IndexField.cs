using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_IndexField))]
#if Dev
    [RunLocal]
#endif

	public class EF_IndexField:ReadOnlyBase<EF_IndexField>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string IndexName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_IndexField Create()
        {
            return EF.DataPortal.Create<EF_IndexField>();
        }

		public static EF_IndexField Fetch(System.Linq.Expressions.Expression<Func<EF_IndexField, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_IndexField>(exp,values);
            return EF.DataPortal.Fetch<EF_IndexField>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_IndexFields))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_IndexFields:ReadOnlyListBase<EF_IndexFields,EF_IndexField>
    {
        #region Factory Methods

        public static EF_IndexFields Fetch()
        {
            return EF.DataPortal.Fetch<EF_IndexFields>();
        }

		public static EF_IndexFields Fetch(System.Linq.Expressions.Expression<Func<EF_IndexField, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_IndexField>(exp,values);
            return EF.DataPortal.Fetch<EF_IndexFields>(lambda);
		}

		public static EF_IndexFields Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_IndexFields>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_IndexFields Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_IndexField, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_IndexFields>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_IndexField>(exp,values)});
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
