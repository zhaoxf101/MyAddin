using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_ContractType))]
#if Dev
    [RunLocal]
#endif

	public class HR_ContractType:ReadOnlyBase<HR_ContractType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ContractType
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

		public static HR_ContractType Create()
        {
            return EF.DataPortal.Create<HR_ContractType>();
        }

		public static HR_ContractType Fetch(System.Linq.Expressions.Expression<Func<HR_ContractType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_ContractType>(exp,values);
            return EF.DataPortal.Fetch<HR_ContractType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_ContractTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_ContractTypes:ReadOnlyListBase<HR_ContractTypes,HR_ContractType>
    {
        #region Factory Methods

        public static HR_ContractTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_ContractTypes>();
        }

		public static HR_ContractTypes Fetch(System.Linq.Expressions.Expression<Func<HR_ContractType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_ContractType>(exp,values);
            return EF.DataPortal.Fetch<HR_ContractTypes>(lambda);
		}

		public static HR_ContractTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_ContractTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_ContractTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_ContractType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_ContractTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_ContractType>(exp,values)});
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
