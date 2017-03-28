using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_DataType))]
#if Dev
    [RunLocal]
#endif

	public class EF_DataType:ReadOnlyBase<EF_DataType>
    {
        #region Business Methods

		
        public string DataType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string SQLType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_DataType Create()
        {
            return EF.DataPortal.Create<EF_DataType>();
        }

		public static EF_DataType Fetch(System.Linq.Expressions.Expression<Func<EF_DataType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_DataType>(exp,values);
            return EF.DataPortal.Fetch<EF_DataType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_DataTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_DataTypes:ReadOnlyListBase<EF_DataTypes,EF_DataType>
    {
        #region Factory Methods

        public static EF_DataTypes Fetch()
        {
            return EF.DataPortal.Fetch<EF_DataTypes>();
        }

		public static EF_DataTypes Fetch(System.Linq.Expressions.Expression<Func<EF_DataType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_DataType>(exp,values);
            return EF.DataPortal.Fetch<EF_DataTypes>(lambda);
		}

		public static EF_DataTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_DataTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_DataTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_DataType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_DataTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_DataType>(exp,values)});
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
