using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TableField))]
#if Dev
    [RunLocal]
#endif

	public class EF_TableField:ReadOnlyBase<EF_TableField>
    {
        #region Business Methods

		
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

		
        public string Active
        {
            get ;
            set ;
        }

		
        public int? Position
        {
            get ;
            set ;
        }

		
        public string KeyFlag
        {
            get ;
            set ;
        }

		
        public string NotNull
        {
            get ;
            set ;
        }

		
        public string DElement
        {
            get ;
            set ;
        }

		
        public string CheckTable
        {
            get ;
            set ;
        }

		
        public string RefTable
        {
            get ;
            set ;
        }

		
        public string RefField
        {
            get ;
            set ;
        }

		
        public string DataType
        {
            get ;
            set ;
        }

		
        public int? Leng
        {
            get ;
            set ;
        }

		
        public int? Decimals
        {
            get ;
            set ;
        }

		
        public string Domain
        {
            get ;
            set ;
        }

		
        public string SHlpOrigin
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

		public static EF_TableField Create()
        {
            return EF.DataPortal.Create<EF_TableField>();
        }

		public static EF_TableField Fetch(System.Linq.Expressions.Expression<Func<EF_TableField, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TableField>(exp,values);
            return EF.DataPortal.Fetch<EF_TableField>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TableFields))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TableFields:ReadOnlyListBase<EF_TableFields,EF_TableField>
    {
        #region Factory Methods

        public static EF_TableFields Fetch()
        {
            return EF.DataPortal.Fetch<EF_TableFields>();
        }

		public static EF_TableFields Fetch(System.Linq.Expressions.Expression<Func<EF_TableField, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TableField>(exp,values);
            return EF.DataPortal.Fetch<EF_TableFields>(lambda);
		}

		public static EF_TableFields Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TableFields>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TableFields Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TableField, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TableFields>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TableField>(exp,values)});
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
