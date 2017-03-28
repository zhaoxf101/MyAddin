using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_StaffType))]
#if Dev
    [RunLocal]
#endif

	public class HR_StaffType:ReadOnlyBase<HR_StaffType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string StaffTypeCode
        {
            get ;
            set ;
        }

		
        public string StaffTypeName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string ImportCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_StaffType Create()
        {
            return EF.DataPortal.Create<HR_StaffType>();
        }

		public static HR_StaffType Fetch(System.Linq.Expressions.Expression<Func<HR_StaffType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_StaffType>(exp,values);
            return EF.DataPortal.Fetch<HR_StaffType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_StaffTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_StaffTypes:ReadOnlyListBase<HR_StaffTypes,HR_StaffType>
    {
        #region Factory Methods

        public static HR_StaffTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_StaffTypes>();
        }

		public static HR_StaffTypes Fetch(System.Linq.Expressions.Expression<Func<HR_StaffType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_StaffType>(exp,values);
            return EF.DataPortal.Fetch<HR_StaffTypes>(lambda);
		}

		public static HR_StaffTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_StaffTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_StaffTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_StaffType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_StaffTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_StaffType>(exp,values)});
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
