using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_FKeyField))]
#if Dev
    [RunLocal]
#endif

	public class EF_FKeyField:ReadOnlyBase<EF_FKeyField>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string FKeyTable
        {
            get ;
            set ;
        }

		
        public string FKeyField
        {
            get ;
            set ;
        }

		
        public string TableField
        {
            get ;
            set ;
        }

		
        public bool ConstX
        {
            get ;
            set ;
        }

		
        public string ForVal
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_FKeyField Create()
        {
            return EF.DataPortal.Create<EF_FKeyField>();
        }

		public static EF_FKeyField Fetch(System.Linq.Expressions.Expression<Func<EF_FKeyField, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_FKeyField>(exp,values);
            return EF.DataPortal.Fetch<EF_FKeyField>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_FKeyFields))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_FKeyFields:ReadOnlyListBase<EF_FKeyFields,EF_FKeyField>
    {
        #region Factory Methods

        public static EF_FKeyFields Fetch()
        {
            return EF.DataPortal.Fetch<EF_FKeyFields>();
        }

		public static EF_FKeyFields Fetch(System.Linq.Expressions.Expression<Func<EF_FKeyField, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_FKeyField>(exp,values);
            return EF.DataPortal.Fetch<EF_FKeyFields>(lambda);
		}

		public static EF_FKeyFields Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_FKeyFields>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_FKeyFields Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_FKeyField, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_FKeyFields>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_FKeyField>(exp,values)});
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
