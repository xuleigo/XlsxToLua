﻿using System.Collections.Generic;

public class AppValues
{
    /// <summary>
    /// Excel文件中存放数据的工作簿Sheet名
    /// </summary>
    public const string EXCEL_DATA_SHEET_NAME = "data";

    /// <summary>
    /// Excel文件中存放该表格配置的工作簿Sheet名
    /// </summary>
    public const string EXCEL_CONFIG_SHEET_NAME = "config";

    /// <summary>
    /// 配置文件（配置自定义的检查规则）的文件名
    /// </summary>
    public const string CONFIG_FILE_NAME = "config.txt";

    // config配置文件中的配置项key名
    // MySQL连接字符串
    public const string APP_CONFIG_MYSQL_CONNECT_STRING_KEY = "connectMySQLString";
    // 导出Excel文件所在路径
    public const string APP_CONFIG_EXPORT_EXCEL_PATH_KEY = "exportExcelPath";
    // 需导出的数据表的表名
    public const string APP_CONFIG_EXPORT_DATA_TABLE_NAMES_KEY = "exportDataTableNames";
    // 各列背景色的ColorIndex
    public const string APP_CONFIG_COLUMN_BACKGROUND_COLOR_KEY = "columnBackgroundColor";
    // data表标签按钮背景色的ColorIndex
    public const string APP_CONFIG_DATA_SHEET_TAB_COLOR_KEY = "dataSheetTabColor";
    // config表标签按钮背景色的ColorIndex
    public const string APP_CONFIG_CONFIG_SHEET_TAB_COLOR_KEY = "configSheetTabColor";

    // 每张Excel表格中，名为data的Sheet表前五行分别声明字段描述、字段变量名、字段数据类型、字段检查规则、导出到数据库中的字段名及类型（行编号从1开始）
    public const int DATA_FIELD_DESC_INDEX = 1;
    public const int DATA_FIELD_NAME_INDEX = 2;
    public const int DATA_FIELD_DATA_TYPE_INDEX = 3;
    public const int DATA_FIELD_CHECK_RULE_INDEX = 4;
    public const int DATA_FIELD_EXPORT_DATABASE_FIELD_INFO = 5;
    public const int DATA_FIELD_DATA_START_INDEX = 6;

    // 每张Excel表格中，名为config的Sheet表可用的配置参数
    // 声明某张表格导出到数据库中的表名
    public const string CONFIG_NAME_EXPORT_DATABASE_TABLE_NAME = "exportDatabaseTableName";

    /// <summary>
    /// 本工具所在目录，不能用System.Environment.CurrentDirectory因为当本工具被其他程序调用时取得的CurrentDirectory将是调用者的路径
    /// </summary>
    public static string PROGRAM_FOLDER_PATH = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

    /// <summary>
    /// config文件转为键值对形式（key：配置文件中的key名， value：对应的配置规则字符串）
    /// </summary>
    public static Dictionary<string, string> ConfigData = new Dictionary<string, string>();

    /// <summary>
    /// 设置的导出Excel文件的存储路径
    /// </summary>
    public static string ExportExcelPath = null;

    /// <summary>
    /// 设置的各列背景色的ColorIndex
    /// </summary>
    public static List<int> ColumnBackgroundColorIndex = null;

    /// <summary>
    /// data表标签按钮背景色的ColorIndex
    /// </summary>
    public static int DataSheetTabColorIndex = 0;

    /// <summary>
    /// config表标签按钮背景色的ColorIndex
    /// </summary>
    public static int ConfigSheetTabColorIndex = 0;
}
