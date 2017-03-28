using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AuthObjField))]
#if Dev
    [RunLocal]
#endif

	public class EF_AuthObjField:ReadOnlyBase<EF_AuthObjField>
    {
        #region Business Methods

		
        public string AObject
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_AuthObjField Create()
        {
            return EF.DataPortal.Create<EF_AuthObjField>();
        }

		public static EF_AuthObjField Fetch(System.Linq.Expressions.Expression<Func<EF_AuthObjField, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthObjField>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthObjField>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AuthObjFields))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AuthObjFields:ReadOnlyListBase<EF_AuthObjFields,EF_AuthObjField>
    {
        #region Factory Methods

        public static EF_AuthObjFields Fetch()
        {
            return EF.DataPortal.Fetch<EF_AuthObjFields>();
        }

		public static EF_AuthObjFields Fetch(System.Linq.Expressions.Expression<Func<EF_AuthObjField, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthObjField>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthObjFields>(lambda);
		}

		public static EF_AuthObjFields Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AuthObjFields>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AuthObjFields Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AuthObjField, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AuthObjFields>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AuthObjField>(exp,values)});
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
