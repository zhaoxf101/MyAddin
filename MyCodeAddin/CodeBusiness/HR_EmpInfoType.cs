using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpInfoType))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpInfoType:ReadOnlyBase<HR_EmpInfoType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InfoType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string WebObject
        {
            get ;
            set ;
        }

		
        public string WinObject
        {
            get ;
            set ;
        }

		
        public string DefautObject
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

		public static HR_EmpInfoType Create()
        {
            return EF.DataPortal.Create<HR_EmpInfoType>();
        }

		public static HR_EmpInfoType Fetch(System.Linq.Expressions.Expression<Func<HR_EmpInfoType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpInfoType>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpInfoType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpInfoTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpInfoTypes:ReadOnlyListBase<HR_EmpInfoTypes,HR_EmpInfoType>
    {
        #region Factory Methods

        public static HR_EmpInfoTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpInfoTypes>();
        }

		public static HR_EmpInfoTypes Fetch(System.Linq.Expressions.Expression<Func<HR_EmpInfoType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpInfoType>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpInfoTypes>(lambda);
		}

		public static HR_EmpInfoTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpInfoTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpInfoTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpInfoType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpInfoTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpInfoType>(exp,values)});
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
