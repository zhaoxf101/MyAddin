using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpRelationDefault))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpRelationDefault:ReadOnlyBase<HR_EmpRelationDefault>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string RelationCode
        {
            get ;
            set ;
        }

		
        public string RelationValue
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpRelationDefault Create()
        {
            return EF.DataPortal.Create<HR_EmpRelationDefault>();
        }

		public static HR_EmpRelationDefault Fetch(System.Linq.Expressions.Expression<Func<HR_EmpRelationDefault, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpRelationDefault>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpRelationDefault>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpRelationDefaults))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpRelationDefaults:ReadOnlyListBase<HR_EmpRelationDefaults,HR_EmpRelationDefault>
    {
        #region Factory Methods

        public static HR_EmpRelationDefaults Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpRelationDefaults>();
        }

		public static HR_EmpRelationDefaults Fetch(System.Linq.Expressions.Expression<Func<HR_EmpRelationDefault, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpRelationDefault>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpRelationDefaults>(lambda);
		}

		public static HR_EmpRelationDefaults Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpRelationDefaults>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpRelationDefaults Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpRelationDefault, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpRelationDefaults>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpRelationDefault>(exp,values)});
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
