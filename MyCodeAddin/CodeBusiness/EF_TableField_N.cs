using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TableField_N))]
#if Dev
    [RunLocal]
#endif

	public class EF_TableField_N:ReadOnlyBase<EF_TableField_N>
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

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public Guid FieldId
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
        public bool PKeyX
        {
            get ;
            set ;
        }

		
        public string DataElement
        {
            get ;
            set ;
        }

		
        public string Domain
        {
            get ;
            set ;
        }

		
        public string DataType
        {
            get ;
            set ;
        }

		
        public int Leng
        {
            get ;
            set ;
        }

		
        public int Decimals
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string RefTableName
        {
            get ;
            set ;
        }

		
        public string RefField
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_TableField_N Create()
        {
            return EF.DataPortal.Create<EF_TableField_N>();
        }

		public static EF_TableField_N Fetch(System.Linq.Expressions.Expression<Func<EF_TableField_N, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TableField_N>(exp,values);
            return EF.DataPortal.Fetch<EF_TableField_N>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TableField_Ns))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TableField_Ns:ReadOnlyListBase<EF_TableField_Ns,EF_TableField_N>
    {
        #region Factory Methods

        public static EF_TableField_Ns Fetch()
        {
            return EF.DataPortal.Fetch<EF_TableField_Ns>();
        }

		public static EF_TableField_Ns Fetch(System.Linq.Expressions.Expression<Func<EF_TableField_N, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TableField_N>(exp,values);
            return EF.DataPortal.Fetch<EF_TableField_Ns>(lambda);
		}

		public static EF_TableField_Ns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TableField_Ns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TableField_Ns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TableField_N, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TableField_Ns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TableField_N>(exp,values)});
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
