<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output omit-xml-declaration="yes"/>

  <xsl:template match="/">
    <xsl:copy>
      <xsl:apply-templates/>
    </xsl:copy>
  </xsl:template>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>

  <xsl:template name ="summary" match="refentry">
        /// <summary>
        /// <xsl:value-of select="concat(translate(
                  substring(refnamediv/refpurpose, 1, 1), $lowercase, $uppercase),
                  substring(refnamediv/refpurpose, 2, string-length(refnamediv/refpurpose) - 1))"/>
        /// </summary>

    <xsl:for-each select="refsect1/variablelist/varlistentry">
      <xsl:choose>
        <xsl:when test="../../@id = 'parameters'">
        /// <param name="{term/parameter}">
            <xsl:for-each select="listitem/para">
        /// <para>
        /// <xsl:value-of select="normalize-space(.)"/>
        /// </para>
            </xsl:for-each>
        /// </param>
        </xsl:when>
      </xsl:choose>
    </xsl:for-each>

  </xsl:template>

</xsl:stylesheet>