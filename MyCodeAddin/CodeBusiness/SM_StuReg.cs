using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StuReg))]
#if Dev
    [RunLocal]
#endif

	public class SM_StuReg:ReadOnlyBase<SM_StuReg>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string SDate
        {
            get ;
            set ;
        }

		
        public string EDate
        {
            get ;
            set ;
        }

		
        public string RegCode
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_StuReg Create()
        {
            return EF.DataPortal.Create<SM_StuReg>();
        }

		public static SM_StuReg Fetch(System.Linq.Expressions.Expression<Func<SM_StuReg, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StuReg>(exp,values);
            return EF.DataPortal.Fetch<SM_StuReg>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StuRegs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StuRegs:ReadOnlyListBase<SM_StuRegs,SM_StuReg>
    {
        #region Factory Methods

        public static SM_StuRegs Fetch()
        {
            return EF.DataPortal.Fetch<SM_StuRegs>();
        }

		public static SM_StuRegs Fetch(System.Linq.Expressions.Expression<Func<SM_StuReg, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StuReg>(exp,values);
            return EF.DataPortal.Fetch<SM_StuRegs>(lambda);
		}

		public static SM_StuRegs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StuRegs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StuRegs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StuReg, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StuRegs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StuReg>(exp,values)});
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
