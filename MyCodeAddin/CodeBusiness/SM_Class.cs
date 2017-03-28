using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_Class))]
#if Dev
    [RunLocal]
#endif

	public class SM_Class:ReadOnlyBase<SM_Class>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public int? Year
        {
            get ;
            set ;
        }

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
        public string ClassName
        {
            get ;
            set ;
        }

		
        public string DepartCode
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public DateTime EntranceDate
        {
            get ;
            set ;
        }

		
        public string EntDate
        {
            get ;
            set ;
        }

		
        public string Grade
        {
            get ;
            set ;
        }

		
        public string Graduated
        {
            get ;
            set ;
        }

		
        public string FeeTypeCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public bool IsExternal
        {
            get ;
            set ;
        }

		
        public bool IsConEdu
        {
            get ;
            set ;
        }

		
        public bool? IsTuiAllot
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
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

		public static SM_Class Create()
        {
            return EF.DataPortal.Create<SM_Class>();
        }

		public static SM_Class Fetch(System.Linq.Expressions.Expression<Func<SM_Class, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_Class>(exp,values);
            return EF.DataPortal.Fetch<SM_Class>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_Classs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_Classs:ReadOnlyListBase<SM_Classs,SM_Class>
    {
        #region Factory Methods

        public static SM_Classs Fetch()
        {
            return EF.DataPortal.Fetch<SM_Classs>();
        }

		public static SM_Classs Fetch(System.Linq.Expressions.Expression<Func<SM_Class, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_Class>(exp,values);
            return EF.DataPortal.Fetch<SM_Classs>(lambda);
		}

		public static SM_Classs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_Classs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_Classs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_Class, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_Classs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_Class>(exp,values)});
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
