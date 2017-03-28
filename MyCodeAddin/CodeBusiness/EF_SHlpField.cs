using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SHlpField))]
#if Dev
    [RunLocal]
#endif

	public class EF_SHlpField:ReadOnlyBase<EF_SHlpField>
    {
        #region Business Methods

		
        public string SearchHelp
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public int FieldPos
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
        public bool InputX
        {
            get ;
            set ;
        }

		
        public bool OutputX
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

		public static EF_SHlpField Create()
        {
            return EF.DataPortal.Create<EF_SHlpField>();
        }

		public static EF_SHlpField Fetch(System.Linq.Expressions.Expression<Func<EF_SHlpField, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SHlpField>(exp,values);
            return EF.DataPortal.Fetch<EF_SHlpField>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SHlpFields))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SHlpFields:ReadOnlyListBase<EF_SHlpFields,EF_SHlpField>
    {
        #region Factory Methods

        public static EF_SHlpFields Fetch()
        {
            return EF.DataPortal.Fetch<EF_SHlpFields>();
        }

		public static EF_SHlpFields Fetch(System.Linq.Expressions.Expression<Func<EF_SHlpField, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SHlpField>(exp,values);
            return EF.DataPortal.Fetch<EF_SHlpFields>(lambda);
		}

		public static EF_SHlpFields Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SHlpFields>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SHlpFields Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SHlpField, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SHlpFields>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SHlpField>(exp,values)});
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
