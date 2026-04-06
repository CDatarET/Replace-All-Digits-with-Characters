class Solution:
    def replaceDigits(self, s):
        sb = []
        for i in range(0, len(s), 2):
            sb.append(s[i])
            if i + 1 < len(s):
                sb.append(chr(ord(s[i]) + int(s[i + 1])))
        
        return "".join(sb)
